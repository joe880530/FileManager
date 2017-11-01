using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FileManager._Utility.Class;

namespace FileManager
{
    public partial class Form_FileManager : Form
    {
        private clsFileManager _Field_clsFileManager;

        public Form_FileManager()
        {
            InitializeComponent();
        }

        public void _FileManager_Init()
        {
            clsFileManager _clsFileManager = new clsFileManager();
            _Field_clsFileManager = _clsFileManager;
        }


        private void Form_Main_Load(object sender, EventArgs e)
        {
            _FileManager_Init();
        }


        private void btn_Save_Start_Click(object sender, EventArgs e)
        {
            //_Field_clsFileManager._File_name = textBox_Name.Text;
            //_Field_clsFileManager._File_path = textBox_Path.Text;
            _Field_clsFileManager._File_type = "txt";

            _Field_clsFileManager.save();
        }
    }
}
