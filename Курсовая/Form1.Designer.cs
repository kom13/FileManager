﻿
namespace Курсовая
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ImageList imageList;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListFiles = new System.Windows.Forms.ListView();
            this.namr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateFileOrFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.папкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyFileOrFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.CutFileOrFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.ListDisk = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FilePathTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.TileIcon = new System.Windows.Forms.ToolStripButton();
            this.DetalsIcon = new System.Windows.Forms.ToolStripButton();
            this.ListIcon = new System.Windows.Forms.ToolStripButton();
            this.LargeIcon = new System.Windows.Forms.ToolStripButton();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.NextButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.BigIcon = new System.Windows.Forms.ImageList(this.components);
            imageList = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            imageList.TransparentColor = System.Drawing.Color.Transparent;
            imageList.Images.SetKeyName(0, "icons8-папка-50.icon");
            imageList.Images.SetKeyName(1, "reload_update_refresh_icon_143703.png");
            imageList.Images.SetKeyName(2, "Generica_25576.png");
            imageList.Images.SetKeyName(3, "txt_4177.png");
            imageList.Images.SetKeyName(4, "-forward_90600.png");
            imageList.Images.SetKeyName(5, "bmp_file_name_extension_document_icon-icons.com_61581.png");
            imageList.Images.SetKeyName(6, "document_96668.png");
            // 
            // ListFiles
            // 
            this.ListFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.namr,
            this.columnHeader2,
            this.FileType,
            this.columnHeader4});
            this.ListFiles.ContextMenuStrip = this.contextMenuStrip;
            this.ListFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListFiles.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListFiles.HideSelection = false;
            this.ListFiles.LabelEdit = true;
            this.ListFiles.LargeImageList = imageList;
            this.ListFiles.Location = new System.Drawing.Point(12, 98);
            this.ListFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListFiles.Name = "ListFiles";
            this.ListFiles.Size = new System.Drawing.Size(708, 322);
            this.ListFiles.SmallImageList = imageList;
            this.ListFiles.TabIndex = 0;
            this.ListFiles.UseCompatibleStateImageBehavior = false;
            this.ListFiles.View = System.Windows.Forms.View.List;
            this.ListFiles.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.ListFiles_AfterLabelEdit);
            this.ListFiles.ItemActivate += new System.EventHandler(this.ListFiles_ItemActivate);
            this.ListFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListFiles_MouseClick);
            // 
            // namr
            // 
            this.namr.Text = "Имя";
            this.namr.Width = 260;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "";
            this.columnHeader2.Text = "Дата изменения";
            this.columnHeader2.Width = 170;
            // 
            // FileType
            // 
            this.FileType.Text = "Тип файла";
            this.FileType.Width = 112;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "размер";
            this.columnHeader4.Width = 125;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateFileOrFolder,
            this.CopyFileOrFolder,
            this.CutFileOrFolder,
            this.Insert,
            this.Delete,
            this.Rename,
            this.Refresh});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(191, 172);
            // 
            // CreateFileOrFolder
            // 
            this.CreateFileOrFolder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.папкуToolStripMenuItem,
            this.файлToolStripMenuItem});
            this.CreateFileOrFolder.Name = "CreateFileOrFolder";
            this.CreateFileOrFolder.Size = new System.Drawing.Size(190, 24);
            this.CreateFileOrFolder.Text = "Создать";
            // 
            // папкуToolStripMenuItem
            // 
            this.папкуToolStripMenuItem.Name = "папкуToolStripMenuItem";
            this.папкуToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.папкуToolStripMenuItem.Text = "Папку";
            this.папкуToolStripMenuItem.Click += new System.EventHandler(this.папкуToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.файлToolStripMenuItem.Text = "Текстовый документ";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // CopyFileOrFolder
            // 
            this.CopyFileOrFolder.Name = "CopyFileOrFolder";
            this.CopyFileOrFolder.Size = new System.Drawing.Size(190, 24);
            this.CopyFileOrFolder.Text = "Копировать";
            this.CopyFileOrFolder.Click += new System.EventHandler(this.CopyFileOrFolder_Click);
            // 
            // CutFileOrFolder
            // 
            this.CutFileOrFolder.Name = "CutFileOrFolder";
            this.CutFileOrFolder.Size = new System.Drawing.Size(190, 24);
            this.CutFileOrFolder.Text = "Вырезать";
            this.CutFileOrFolder.Click += new System.EventHandler(this.CutFileOrFolder_Click_1);
            // 
            // Insert
            // 
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(190, 24);
            this.Insert.Text = "Вставить";
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(190, 24);
            this.Delete.Text = "Удалить";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Rename
            // 
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(190, 24);
            this.Rename.Text = "Переименовать";
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // Refresh
            // 
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(190, 24);
            this.Refresh.Text = "Обновить";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // ListDisk
            // 
            this.ListDisk.FormattingEnabled = true;
            this.ListDisk.Location = new System.Drawing.Point(607, 63);
            this.ListDisk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListDisk.Name = "ListDisk";
            this.ListDisk.Size = new System.Drawing.Size(113, 27);
            this.ListDisk.TabIndex = 4;
            this.ListDisk.SelectedIndexChanged += new System.EventHandler(this.ListDisk_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.NextButton,
            this.FilePathTextBox,
            this.RefreshButton});
            this.toolStrip1.Location = new System.Drawing.Point(12, 63);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(592, 31);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(500, 31);
            this.FilePathTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilePathTextBox_KeyDown);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.TileIcon,
            this.DetalsIcon,
            this.ListIcon,
            this.LargeIcon,
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(732, 31);
            this.toolStrip2.TabIndex = 10;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 28);
            this.toolStripLabel1.Text = "Вид";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(92, 28);
            this.toolStripLabel2.Text = "Сортировка";
            // 
            // TileIcon
            // 
            this.TileIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TileIcon.Image = global::Курсовая.Properties.Resources.tileview_tile_view_icon_131494;
            this.TileIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TileIcon.Name = "TileIcon";
            this.TileIcon.Size = new System.Drawing.Size(29, 28);
            this.TileIcon.Text = "Плитка";
            this.TileIcon.Click += new System.EventHandler(this.TileIcon_Click);
            // 
            // DetalsIcon
            // 
            this.DetalsIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DetalsIcon.Image = global::Курсовая.Properties.Resources.Details_Popup_icon_icons_com_55930;
            this.DetalsIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DetalsIcon.Name = "DetalsIcon";
            this.DetalsIcon.Size = new System.Drawing.Size(29, 28);
            this.DetalsIcon.Text = "Детали";
            this.DetalsIcon.Click += new System.EventHandler(this.DetalsIcon_Click);
            // 
            // ListIcon
            // 
            this.ListIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ListIcon.Image = global::Курсовая.Properties.Resources.list_symbol_of_three_items_with_dots_icon_icons_com_72994;
            this.ListIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ListIcon.Name = "ListIcon";
            this.ListIcon.Size = new System.Drawing.Size(29, 28);
            this.ListIcon.Text = "Список";
            this.ListIcon.Click += new System.EventHandler(this.ListIcon_Click);
            // 
            // LargeIcon
            // 
            this.LargeIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LargeIcon.Image = global::Курсовая.Properties.Resources.frame_gallery_image_images_photo_picture_pictures_icon_123209;
            this.LargeIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LargeIcon.Name = "LargeIcon";
            this.LargeIcon.Size = new System.Drawing.Size(29, 28);
            this.LargeIcon.Text = "Большие значки";
            this.LargeIcon.Click += new System.EventHandler(this.LargeIcon_Click);
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackButton.Image = global::Курсовая.Properties.Resources._forward_90600__1_;
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(29, 28);
            this.BackButton.Text = "Назад";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton.Image = global::Курсовая.Properties.Resources._forward_90600;
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(29, 28);
            this.NextButton.Text = "Вперед";
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = global::Курсовая.Properties.Resources.reload_update_refresh_icon_143703;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(29, 28);
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // BigIcon
            // 
            this.BigIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BigIcon.ImageStream")));
            this.BigIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.BigIcon.Images.SetKeyName(0, "Generica_25576.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 433);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ListDisk);
            this.Controls.Add(this.ListFiles);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Файловый менеджер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader FileType;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ColumnHeader namr;
        private System.Windows.Forms.ComboBox ListDisk;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CreateFileOrFolder;
        private System.Windows.Forms.ToolStripMenuItem папкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem CutFileOrFolder;
        private System.Windows.Forms.ToolStripMenuItem Insert;
        private System.Windows.Forms.ToolStripMenuItem Rename;
        private System.Windows.Forms.ToolStripMenuItem CopyFileOrFolder;
        private System.Windows.Forms.ToolStripMenuItem Refresh;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.ToolStripButton NextButton;
        private System.Windows.Forms.ToolStripTextBox FilePathTextBox;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ListView ListFiles;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton TileIcon;
        private System.Windows.Forms.ToolStripButton ListIcon;
        private System.Windows.Forms.ToolStripButton DetalsIcon;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton LargeIcon;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ImageList BigIcon;
    }
}

