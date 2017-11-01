namespace FileManager
{
    partial class Form_FileManager
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_Setting = new System.Windows.Forms.TableLayoutPanel();
            this.label_FileType = new System.Windows.Forms.Label();
            this.label_FolderName = new System.Windows.Forms.Label();
            this.label_MainPath = new System.Windows.Forms.Label();
            this.label_FileName = new System.Windows.Forms.Label();
            this.textBox_MainPath = new System.Windows.Forms.TextBox();
            this.textBox_FolderName = new System.Windows.Forms.TextBox();
            this.textBox_FileName = new System.Windows.Forms.TextBox();
            this.btn_Save_Start = new System.Windows.Forms.Button();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_Label = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_Button = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_TextBox = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel_Setting.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Setting
            // 
            this.tableLayoutPanel_Setting.ColumnCount = 2;
            this.tableLayoutPanel_Setting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.90541F));
            this.tableLayoutPanel_Setting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.0946F));
            this.tableLayoutPanel_Setting.Controls.Add(this.label_FileType, 0, 3);
            this.tableLayoutPanel_Setting.Controls.Add(this.label_FolderName, 0, 1);
            this.tableLayoutPanel_Setting.Controls.Add(this.label_MainPath, 0, 0);
            this.tableLayoutPanel_Setting.Controls.Add(this.label_FileName, 0, 2);
            this.tableLayoutPanel_Setting.Controls.Add(this.textBox_MainPath, 1, 0);
            this.tableLayoutPanel_Setting.Controls.Add(this.textBox_FolderName, 1, 1);
            this.tableLayoutPanel_Setting.Controls.Add(this.textBox_FileName, 1, 2);
            this.tableLayoutPanel_Setting.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Setting.Name = "tableLayoutPanel_Setting";
            this.tableLayoutPanel_Setting.RowCount = 4;
            this.tableLayoutPanel_Setting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Setting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Setting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Setting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Setting.Size = new System.Drawing.Size(592, 162);
            this.tableLayoutPanel_Setting.TabIndex = 5;
            // 
            // label_FileType
            // 
            this.label_FileType.AutoSize = true;
            this.label_FileType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_FileType.Location = new System.Drawing.Point(3, 120);
            this.label_FileType.Name = "label_FileType";
            this.label_FileType.Size = new System.Drawing.Size(100, 42);
            this.label_FileType.TabIndex = 7;
            this.label_FileType.Text = "File Type";
            this.label_FileType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_FolderName
            // 
            this.label_FolderName.AutoSize = true;
            this.label_FolderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_FolderName.Location = new System.Drawing.Point(3, 40);
            this.label_FolderName.Name = "label_FolderName";
            this.label_FolderName.Size = new System.Drawing.Size(100, 40);
            this.label_FolderName.TabIndex = 5;
            this.label_FolderName.Text = "Folder Name";
            this.label_FolderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_MainPath
            // 
            this.label_MainPath.AutoSize = true;
            this.label_MainPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_MainPath.Location = new System.Drawing.Point(3, 0);
            this.label_MainPath.Name = "label_MainPath";
            this.label_MainPath.Size = new System.Drawing.Size(100, 40);
            this.label_MainPath.TabIndex = 4;
            this.label_MainPath.Text = "Main Path";
            this.label_MainPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_FileName
            // 
            this.label_FileName.AutoSize = true;
            this.label_FileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_FileName.Location = new System.Drawing.Point(3, 80);
            this.label_FileName.Name = "label_FileName";
            this.label_FileName.Size = new System.Drawing.Size(100, 40);
            this.label_FileName.TabIndex = 6;
            this.label_FileName.Text = "File Name";
            this.label_FileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_MainPath
            // 
            this.textBox_MainPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_MainPath.Location = new System.Drawing.Point(109, 9);
            this.textBox_MainPath.Name = "textBox_MainPath";
            this.textBox_MainPath.Size = new System.Drawing.Size(480, 21);
            this.textBox_MainPath.TabIndex = 8;
            this.textBox_MainPath.Text = "C:\\Users\\Daekhon_jiho\\Desktop\\test_Folder";
            // 
            // textBox_FolderName
            // 
            this.textBox_FolderName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_FolderName.Location = new System.Drawing.Point(109, 49);
            this.textBox_FolderName.Name = "textBox_FolderName";
            this.textBox_FolderName.Size = new System.Drawing.Size(480, 21);
            this.textBox_FolderName.TabIndex = 9;
            this.textBox_FolderName.Text = "Name";
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_FileName.Location = new System.Drawing.Point(109, 89);
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.Size = new System.Drawing.Size(480, 21);
            this.textBox_FileName.TabIndex = 10;
            // 
            // btn_Save_Start
            // 
            this.btn_Save_Start.Location = new System.Drawing.Point(745, 66);
            this.btn_Save_Start.Name = "btn_Save_Start";
            this.btn_Save_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Save_Start.TabIndex = 6;
            this.btn_Save_Start.Text = "Save Start";
            this.btn_Save_Start.UseVisualStyleBackColor = true;
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.flowLayoutPanel_TextBox);
            this.panel_Main.Controls.Add(this.flowLayoutPanel_Button);
            this.panel_Main.Controls.Add(this.flowLayoutPanel_Label);
            this.panel_Main.Location = new System.Drawing.Point(192, 194);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(666, 187);
            this.panel_Main.TabIndex = 7;
            // 
            // flowLayoutPanel_Label
            // 
            this.flowLayoutPanel_Label.Location = new System.Drawing.Point(36, 35);
            this.flowLayoutPanel_Label.Name = "flowLayoutPanel_Label";
            this.flowLayoutPanel_Label.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel_Label.TabIndex = 0;
            // 
            // flowLayoutPanel_Button
            // 
            this.flowLayoutPanel_Button.Location = new System.Drawing.Point(382, 35);
            this.flowLayoutPanel_Button.Name = "flowLayoutPanel_Button";
            this.flowLayoutPanel_Button.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel_Button.TabIndex = 0;
            // 
            // flowLayoutPanel_TextBox
            // 
            this.flowLayoutPanel_TextBox.Location = new System.Drawing.Point(258, 48);
            this.flowLayoutPanel_TextBox.Name = "flowLayoutPanel_TextBox";
            this.flowLayoutPanel_TextBox.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel_TextBox.TabIndex = 1;
            // 
            // Form_FileManager
            // 
            this.ClientSize = new System.Drawing.Size(900, 393);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.btn_Save_Start);
            this.Controls.Add(this.tableLayoutPanel_Setting);
            this.Name = "Form_FileManager";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.tableLayoutPanel_Setting.ResumeLayout(false);
            this.tableLayoutPanel_Setting.PerformLayout();
            this.panel_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Setting;
        private System.Windows.Forms.Label label_FileType;
        private System.Windows.Forms.Label label_FolderName;
        private System.Windows.Forms.Label label_MainPath;
        private System.Windows.Forms.Label label_FileName;
        private System.Windows.Forms.TextBox textBox_MainPath;
        private System.Windows.Forms.TextBox textBox_FolderName;
        private System.Windows.Forms.TextBox textBox_FileName;
        private System.Windows.Forms.Button btn_Save_Start;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_TextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Label;
    }
}
