
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
            System.Windows.Forms.ImageList imageList1;
            this.ListFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Create = new System.Windows.Forms.ToolStripMenuItem();
            this.папкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.ListDisk = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.NextButton = new System.Windows.Forms.ToolStripButton();
            this.FilePathTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.Tile = new System.Windows.Forms.ToolStripButton();
            this.List = new System.Windows.Forms.ToolStripButton();
            this.Table = new System.Windows.Forms.ToolStripButton();
            this.Images = new System.Windows.Forms.ToolStripButton();
            this.SmallImages = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TileIcon = new System.Windows.Forms.ToolStripButton();
            this.DetalsIcon = new System.Windows.Forms.ToolStripButton();
            this.ListIcon = new System.Windows.Forms.ToolStripButton();
            this.LargeIcon = new System.Windows.Forms.ToolStripButton();
            this.SmallIcon = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.Cut = new System.Windows.Forms.ToolStripMenuItem();
            imageList = new System.Windows.Forms.ImageList(this.components);
            imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            imageList.TransparentColor = System.Drawing.Color.Transparent;
            imageList.Images.SetKeyName(0, "folderorangeopen_93000.png");
            imageList.Images.SetKeyName(1, "txt_4177.png");
            imageList.Images.SetKeyName(2, "bmp_file_name_extension_document_icon-icons.com_61581.png");
            imageList.Images.SetKeyName(3, "document_96668.png");
            // 
            // ListFiles
            // 
            this.ListFiles.AllowDrop = true;
            this.ListFiles.BackColor = System.Drawing.SystemColors.Window;
            this.ListFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListFiles.ContextMenuStrip = this.contextMenuStrip;
            this.ListFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListFiles.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListFiles.HideSelection = false;
            this.ListFiles.LabelEdit = true;
            this.ListFiles.LargeImageList = imageList1;
            this.ListFiles.Location = new System.Drawing.Point(0, 58);
            this.ListFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListFiles.Name = "ListFiles";
            this.ListFiles.Size = new System.Drawing.Size(712, 366);
            this.ListFiles.SmallImageList = imageList;
            this.ListFiles.TabIndex = 0;
            this.ListFiles.UseCompatibleStateImageBehavior = false;
            this.ListFiles.View = System.Windows.Forms.View.Details;
            this.ListFiles.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.ListFiles_AfterLabelEdit);
            this.ListFiles.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListFiles_ColumnClick);
            this.ListFiles.ItemActivate += new System.EventHandler(this.ListFiles_ItemActivate);
            this.ListFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListFiles_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дата создания";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Расширение";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Размер";
            this.columnHeader4.Width = 145;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create,
            this.Cut,
            this.Copy,
            this.Insert,
            this.Delete,
            this.Rename,
            this.Refresh});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(191, 172);
            // 
            // Create
            // 
            this.Create.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.папкуToolStripMenuItem,
            this.файлToolStripMenuItem});
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(190, 24);
            this.Create.Text = "Создать";
            // 
            // папкуToolStripMenuItem
            // 
            this.папкуToolStripMenuItem.Name = "папкуToolStripMenuItem";
            this.папкуToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.папкуToolStripMenuItem.Text = "Папку";
            this.папкуToolStripMenuItem.Click += new System.EventHandler(this.CreateToFolder);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.файлToolStripMenuItem.Text = "Текстовый документ";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.CreateToFile);
            // 
            // Copy
            // 
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(190, 24);
            this.Copy.Text = "Копировать";
            this.Copy.Click += new System.EventHandler(this.CopyFileOrFolder_Click);
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
            this.ListDisk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListDisk.FormattingEnabled = true;
            this.ListDisk.Location = new System.Drawing.Point(616, 27);
            this.ListDisk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListDisk.Name = "ListDisk";
            this.ListDisk.Size = new System.Drawing.Size(96, 27);
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(630, 27);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(29, 24);
            this.BackButton.Text = "toolStripButton6";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(29, 24);
            this.NextButton.Text = "NextButton";
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilePathTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(538, 27);
            this.FilePathTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilePathTextBox_KeyDown);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(29, 24);
            this.RefreshButton.Text = "toolStripButton8";
            this.RefreshButton.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.Tile,
            this.List,
            this.Table,
            this.Images,
            this.SmallImages});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(712, 27);
            this.toolStrip2.TabIndex = 10;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 24);
            this.toolStripLabel3.Text = "Вид";
            // 
            // Tile
            // 
            this.Tile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tile.Image = global::Курсовая.Properties.Resources.tile;
            this.Tile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tile.Name = "Tile";
            this.Tile.Size = new System.Drawing.Size(29, 24);
            this.Tile.Text = "Плитка";
            this.Tile.Click += new System.EventHandler(this.TileIcon_Click);
            // 
            // List
            // 
            this.List.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.List.Image = ((System.Drawing.Image)(resources.GetObject("List.Image")));
            this.List.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(29, 24);
            this.List.Text = "Список";
            this.List.Click += new System.EventHandler(this.ListIcon_Click);
            // 
            // Table
            // 
            this.Table.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Table.Image = ((System.Drawing.Image)(resources.GetObject("Table.Image")));
            this.Table.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(29, 24);
            this.Table.Text = "Таблица";
            this.Table.Click += new System.EventHandler(this.DetalsIcon_Click);
            // 
            // Images
            // 
            this.Images.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Images.Image = ((System.Drawing.Image)(resources.GetObject("Images.Image")));
            this.Images.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Images.Name = "Images";
            this.Images.Size = new System.Drawing.Size(29, 24);
            this.Images.Text = "Обычные значки";
            this.Images.Click += new System.EventHandler(this.LargeIcon_Click);
            // 
            // SmallImages
            // 
            this.SmallImages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SmallImages.Image = ((System.Drawing.Image)(resources.GetObject("SmallImages.Image")));
            this.SmallImages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SmallImages.Name = "SmallImages";
            this.SmallImages.Size = new System.Drawing.Size(29, 24);
            this.SmallImages.Text = "Маленькие значки";
            this.SmallImages.Click += new System.EventHandler(this.SmallIcon_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 28);
            this.toolStripLabel1.Text = "Вид";
            // 
            // TileIcon
            // 
            this.TileIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TileIcon.Image = global::Курсовая.Properties.Resources.tile;
            this.TileIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TileIcon.Name = "TileIcon";
            this.TileIcon.Size = new System.Drawing.Size(29, 28);
            this.TileIcon.Text = "Плитка";
            this.TileIcon.Click += new System.EventHandler(this.TileIcon_Click);
            // 
            // DetalsIcon
            // 
            this.DetalsIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DetalsIcon.Image = global::Курсовая.Properties.Resources.tablet;
            this.DetalsIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DetalsIcon.Name = "DetalsIcon";
            this.DetalsIcon.Size = new System.Drawing.Size(29, 28);
            this.DetalsIcon.Text = "Таблица";
            this.DetalsIcon.Click += new System.EventHandler(this.DetalsIcon_Click);
            // 
            // ListIcon
            // 
            this.ListIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ListIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ListIcon.Name = "ListIcon";
            this.ListIcon.Size = new System.Drawing.Size(29, 28);
            this.ListIcon.Text = "Список";
            this.ListIcon.Click += new System.EventHandler(this.ListIcon_Click);
            // 
            // LargeIcon
            // 
            this.LargeIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LargeIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LargeIcon.Name = "LargeIcon";
            this.LargeIcon.Size = new System.Drawing.Size(29, 24);
            this.LargeIcon.Text = "Обычные значки";
            this.LargeIcon.Click += new System.EventHandler(this.LargeIcon_Click);
            // 
            // SmallIcon
            // 
            this.SmallIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SmallIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SmallIcon.Name = "SmallIcon";
            this.SmallIcon.Size = new System.Drawing.Size(29, 24);
            this.SmallIcon.Text = "Мелкие значки";
            this.SmallIcon.Click += new System.EventHandler(this.SmallIcon_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(92, 28);
            this.toolStripLabel2.Text = "Сортировка";
            // 
            // Cut
            // 
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(190, 24);
            this.Cut.Text = "Вырезать";
            this.Cut.Click += new System.EventHandler(this.CutFileOrFolder);
            // 
            // imageList1
            // 
            imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "folderorangeopen_93000.png");
            imageList1.Images.SetKeyName(1, "txt_4177.png");
            imageList1.Images.SetKeyName(2, "bmp_file_name_extension_document_icon-icons.com_61581.png");
            imageList1.Images.SetKeyName(3, "document_96668.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 424);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ListDisk);
            this.Controls.Add(this.ListFiles);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.ComboBox ListDisk;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Create;
        private System.Windows.Forms.ToolStripMenuItem папкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem Insert;
        private System.Windows.Forms.ToolStripMenuItem Rename;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Refresh;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListView ListFiles;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton TileIcon;
        private System.Windows.Forms.ToolStripButton ListIcon;
        private System.Windows.Forms.ToolStripButton DetalsIcon;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton LargeIcon;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton SmallIcon;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.ToolStripButton NextButton;
        private System.Windows.Forms.ToolStripTextBox FilePathTextBox;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton Tile;
        private System.Windows.Forms.ToolStripButton List;
        private System.Windows.Forms.ToolStripButton Table;
        private System.Windows.Forms.ToolStripButton Images;
        private System.Windows.Forms.ToolStripButton SmallImages;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem Cut;
    }
}

