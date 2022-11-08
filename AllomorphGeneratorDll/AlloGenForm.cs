﻿// Copyright (c) 2022 SIL International
// This software is licensed under the LGPL, version 2.1 or later
// (http://www.gnu.org/licenses/lgpl-2.1.html)

using Microsoft.Win32;
using SIL.AlloGenModel;
using SIL.AlloGenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIL.AllomorphGenerator
{
    public partial class AlloGenForm : Form
    {

        private RegistryKey regkey;
        public static string m_strRegKey = "Software\\SIL\\AllomorphGenerator";
        const string m_strLastDatabase = "LastDatabase";
        const string m_strLastOperationsFile = "LastOperationsFile";
        const string m_strLastOperation = "Lastoperation";
        const string m_strLocationX = "LocationX";
        const string m_strLocationY = "LocationY";
        const string m_strSizeHeight = "SizeHeight";
        const string m_strSizeWidth = "SizeWidth";
        const string m_strWindowState = "WindowState";

        public Rectangle RectNormal { get; set; }

        public string LastDatabase { get; set; }
        public string LastOperationsFile { get; set; }
        public int LastOperation { get; set; }
        public string LastRootGlossSelection { get; set; }
        public int RetrievedLastOperation { get; set; }

        private String OperationsFile { get; set; }
        AllomorphGenerators AlloGens { get; set; }
        List<Operation> Operations { get; set; }

        public AlloGenForm()
        {
            InitializeComponent();
            try
            {
                RememberFormState();
                XmlBackEndProvider provider = new XmlBackEndProvider();
                provider.LoadDataFromFile(OperationsFile);
                AlloGens = provider.AlloGens;
                if (AlloGens != null)
                {
                    Operations = AlloGens.Operations;
                }
                FillOperationsListBox();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.StackTrace);
            }
        }

        private void RememberFormState()
        {
            regkey = Registry.CurrentUser.OpenSubKey(m_strRegKey);
            if (regkey != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();
                RetrieveRegistryInfo();
                regkey.Close();
                DesktopBounds = RectNormal;
                WindowState = WindowState;
                StartPosition = FormStartPosition.Manual;
                if (!String.IsNullOrEmpty(LastOperationsFile))
                    tbFile.Text = LastOperationsFile;
                Cursor.Current = Cursors.Default;
            }
        }

        void RetrieveRegistryInfo()
        {
            // Window location
            int iX = (int)regkey.GetValue(m_strLocationX, 100);
            int iY = (int)regkey.GetValue(m_strLocationY, 100);
            int iWidth = (int)regkey.GetValue(m_strSizeWidth, 809); // 1228);
            int iHeight = (int)regkey.GetValue(m_strSizeHeight, 670); // 947);
            RectNormal = new Rectangle(iX, iY, iWidth, iHeight);
            // Set form properties
            WindowState = (FormWindowState)regkey.GetValue(m_strWindowState, 0);

            LastDatabase = (string)regkey.GetValue(m_strLastDatabase);
            OperationsFile = LastOperationsFile = (string)regkey.GetValue(m_strLastOperationsFile);
            RetrievedLastOperation = LastOperation = (int)regkey.GetValue(m_strLastOperation, 1);

        }

        public void SaveRegistryInfo()
        {
            regkey = Registry.CurrentUser.OpenSubKey(m_strRegKey, true);
            if (regkey == null)
            {
                regkey = Registry.CurrentUser.CreateSubKey(m_strRegKey);
            }

            if (LastDatabase != null)
                regkey.SetValue(m_strLastDatabase, LastDatabase);
            if (LastOperationsFile != null)
                regkey.SetValue(m_strLastOperationsFile, LastOperationsFile);
            regkey.SetValue(m_strLastOperation, LastOperation);
            // Window position and location
            regkey.SetValue(m_strWindowState, (int)WindowState);
            regkey.SetValue(m_strLocationX, RectNormal.X);
            regkey.SetValue(m_strLocationY, RectNormal.Y);
            regkey.SetValue(m_strSizeWidth, RectNormal.Width);
            regkey.SetValue(m_strSizeHeight, RectNormal.Height);
            regkey.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Allomorph Generator Operations File (*.agf)|*.agf|" +
            "All Files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                OperationsFile = dlg.FileName;
                LastOperationsFile = OperationsFile;
                tbFile.Text = OperationsFile;
            }
        }
        private void OnFormClosing(object sender, EventArgs e)
        {
            Console.WriteLine("form closing");
            SaveRegistryInfo();
        }
        protected override void OnMove(EventArgs ea)
        {
            base.OnMove(ea);

            if (WindowState == FormWindowState.Normal)
                RectNormal = DesktopBounds;
        }
        protected override void OnResize(EventArgs ea)
        {
            base.OnResize(ea);

            if (WindowState == FormWindowState.Normal)
                RectNormal = DesktopBounds;
        }

        public void FillOperationsListBox()
        {
            lbOperations.DataSource = Operations;
            // select last used operation, if any
            if (LastOperation < 0 || LastOperation >= Operations.Count)
                LastOperation = 1;
            var selectedOperation = Operations[LastOperation];
        }

        private void lbOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operation operation = lbOperations.SelectedItem as Operation;
            LastOperation = lbOperations.SelectedIndex;
            tbName.Text = operation.Name;
            tbDescription.Text = operation.Description;
            Pattern pattern = operation.Pattern;
            tbMatch.Text = pattern.Match;
            lbMorphTypes.DataSource = pattern.MorphTypes;
            //MessageBox.Show("mt count = " + lbMorphTypes.Container.Components.Count);
            //MessageBox.Show("mt count = " + pattern.MorphTypes.Count);
            if (pattern.MorphTypes.Count > 0)
            {
                var selectedMorphType = pattern.MorphTypes[1];
            }

        }

        private void lbMorphTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
