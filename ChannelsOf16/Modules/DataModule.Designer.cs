namespace 延迟线收发组件_十六通道.Modules
{
    partial class DataModule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataModule));
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton_连接测试 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_矢网地址 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_保存路径 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxEdit_类型选择 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit_采集延时 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_采集通道 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_组件编号 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitch_开关 = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_矢网地址.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_保存路径.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_类型选择.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_采集延时.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_采集通道.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_组件编号.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_开关.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton_连接测试);
            this.groupControl1.Controls.Add(this.textEdit_矢网地址);
            this.groupControl1.Controls.Add(this.textEdit_保存路径);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(314, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(327, 367);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "矢网采集设置";
            // 
            // simpleButton_连接测试
            // 
            this.simpleButton_连接测试.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_连接测试.Appearance.Options.UseFont = true;
            this.simpleButton_连接测试.ImageOptions.Image = global::延迟线收发组件_十六通道.Properties.Resources.alignverticalcenter2_32x32;
            this.simpleButton_连接测试.Location = new System.Drawing.Point(47, 228);
            this.simpleButton_连接测试.Name = "simpleButton_连接测试";
            this.simpleButton_连接测试.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton_连接测试.Size = new System.Drawing.Size(229, 67);
            this.simpleButton_连接测试.TabIndex = 2;
            this.simpleButton_连接测试.Text = "连接测试";
            this.simpleButton_连接测试.Click += new System.EventHandler(this.simpleButton_连接测试_Click);
            // 
            // textEdit_矢网地址
            // 
            this.textEdit_矢网地址.EditValue = "GPIB0::16::INSTR";
            this.textEdit_矢网地址.Location = new System.Drawing.Point(128, 93);
            this.textEdit_矢网地址.Name = "textEdit_矢网地址";
            this.textEdit_矢网地址.Size = new System.Drawing.Size(148, 20);
            this.textEdit_矢网地址.TabIndex = 1;
            // 
            // textEdit_保存路径
            // 
            this.textEdit_保存路径.EditValue = "D:/default/";
            this.textEdit_保存路径.Location = new System.Drawing.Point(128, 157);
            this.textEdit_保存路径.Name = "textEdit_保存路径";
            this.textEdit_保存路径.Size = new System.Drawing.Size(148, 20);
            this.textEdit_保存路径.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(47, 95);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 17);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "矢网地址：";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(47, 159);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 17);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "保存路径：";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.toggleSwitch_开关);
            this.groupControl2.Controls.Add(this.comboBoxEdit_类型选择);
            this.groupControl2.Controls.Add(this.textEdit_采集延时);
            this.groupControl2.Controls.Add(this.textEdit_采集通道);
            this.groupControl2.Controls.Add(this.textEdit_组件编号);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(314, 367);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "常规设置";
            // 
            // comboBoxEdit_类型选择
            // 
            this.comboBoxEdit_类型选择.Location = new System.Drawing.Point(122, 114);
            this.comboBoxEdit_类型选择.Name = "comboBoxEdit_类型选择";
            this.comboBoxEdit_类型选择.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_类型选择.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit_类型选择.Size = new System.Drawing.Size(148, 20);
            this.comboBoxEdit_类型选择.TabIndex = 8;
            // 
            // textEdit_采集延时
            // 
            this.textEdit_采集延时.EditValue = "1000";
            this.textEdit_采集延时.Location = new System.Drawing.Point(122, 220);
            this.textEdit_采集延时.Name = "textEdit_采集延时";
            this.textEdit_采集延时.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_采集延时.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.textEdit_采集延时.Properties.Appearance.Options.UseFont = true;
            this.textEdit_采集延时.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit_采集延时.Size = new System.Drawing.Size(148, 24);
            this.textEdit_采集延时.TabIndex = 6;
            // 
            // textEdit_采集通道
            // 
            this.textEdit_采集通道.EditValue = "1";
            this.textEdit_采集通道.Enabled = false;
            this.textEdit_采集通道.Location = new System.Drawing.Point(122, 167);
            this.textEdit_采集通道.Name = "textEdit_采集通道";
            this.textEdit_采集通道.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_采集通道.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.textEdit_采集通道.Properties.Appearance.Options.UseFont = true;
            this.textEdit_采集通道.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit_采集通道.Size = new System.Drawing.Size(148, 24);
            this.textEdit_采集通道.TabIndex = 6;
            // 
            // textEdit_组件编号
            // 
            this.textEdit_组件编号.EditValue = "1";
            this.textEdit_组件编号.Location = new System.Drawing.Point(122, 66);
            this.textEdit_组件编号.Name = "textEdit_组件编号";
            this.textEdit_组件编号.Size = new System.Drawing.Size(148, 20);
            this.textEdit_组件编号.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(56, 223);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 17);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "采集延时：";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(56, 169);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 17);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "采集通道：";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(56, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "类型选择：";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(56, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 17);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "组件编号：";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(56, 278);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 17);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "采集开关：";
            // 
            // toggleSwitch_开关
            // 
            this.toggleSwitch_开关.EditValue = true;
            this.toggleSwitch_开关.Location = new System.Drawing.Point(122, 274);
            this.toggleSwitch_开关.Name = "toggleSwitch_开关";
            this.toggleSwitch_开关.Properties.OffText = "Off";
            this.toggleSwitch_开关.Properties.OnText = "On";
            this.toggleSwitch_开关.Size = new System.Drawing.Size(95, 25);
            this.toggleSwitch_开关.TabIndex = 9;
            // 
            // DataModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 367);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据采集模块";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_矢网地址.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_保存路径.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_类型选择.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_采集延时.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_采集通道.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_组件编号.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_开关.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_保存路径;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton_连接测试;
        private DevExpress.XtraEditors.TextEdit textEdit_矢网地址;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_类型选择;
        public DevExpress.XtraEditors.TextEdit textEdit_采集通道;
        private DevExpress.XtraEditors.TextEdit textEdit_组件编号;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit textEdit_采集延时;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.ToggleSwitch toggleSwitch_开关;
    }
}