namespace AppQuanLy.GUI
{
     partial class BooksUC
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

          #region Component Designer generated code

          /// <summary> 
          /// Required method for Designer support - do not modify 
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.components = new System.ComponentModel.Container();
               this.gridctrlBook = new DevExpress.XtraGrid.GridControl();
               this.bookViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.gridviewBook = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.label6 = new System.Windows.Forms.Label();
               this.txtbCode = new System.Windows.Forms.TextBox();
               this.txtboxName = new System.Windows.Forms.TextBox();
               this.cmbboxAuthor = new System.Windows.Forms.ComboBox();
               this.authorViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.cmbboxRealeased = new System.Windows.Forms.ComboBox();
               this.publisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.cmbboxPublisher = new System.Windows.Forms.ComboBox();
               this.cmbboxCategory = new System.Windows.Forms.ComboBox();
               this.bookCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.txtbNumberPage = new System.Windows.Forms.TextBox();
               this.txtbWeight = new System.Windows.Forms.TextBox();
               this.txtbPrice = new System.Windows.Forms.TextBox();
               this.txtbImage = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.label8 = new System.Windows.Forms.Label();
               this.label9 = new System.Windows.Forms.Label();
               this.label10 = new System.Windows.Forms.Label();
               this.label11 = new System.Windows.Forms.Label();
               this.txtbDescription = new System.Windows.Forms.TextBox();
               this.label12 = new System.Windows.Forms.Label();
               this.btnAdd = new System.Windows.Forms.Button();
               this.btnEdit = new System.Windows.Forms.Button();
               this.btnSave = new System.Windows.Forms.Button();
               this.btnDelete = new System.Windows.Forms.Button();
               this.picboxImage = new System.Windows.Forms.PictureBox();
               this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colAuthorID = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colReleased = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colReleasedID = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colPublisher = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colPublisherID = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colNumberPage = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colForm = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colPublishDate = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colBuys = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colPromotionPrice = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colViewCount = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colLikeCount = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colInventory = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
               ((System.ComponentModel.ISupportInitialize)(this.gridctrlBook)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.bookViewModelBindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.gridviewBook)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.authorViewModelBindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.bookCategoryBindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).BeginInit();
               this.SuspendLayout();
               // 
               // gridctrlBook
               // 
               this.gridctrlBook.DataSource = this.bookViewModelBindingSource;
               this.gridctrlBook.Location = new System.Drawing.Point(25, 323);
               this.gridctrlBook.MainView = this.gridviewBook;
               this.gridctrlBook.Name = "gridctrlBook";
               this.gridctrlBook.Size = new System.Drawing.Size(1858, 441);
               this.gridctrlBook.TabIndex = 0;
               this.gridctrlBook.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewBook});
               this.gridctrlBook.Load += new System.EventHandler(this.BooksUC_Load);
               // 
               // bookViewModelBindingSource
               // 
               this.bookViewModelBindingSource.DataSource = typeof(AppQuanLy.Models.BookViewModel);
               // 
               // gridviewBook
               // 
               this.gridviewBook.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCode,
            this.colName,
            this.colAuthor,
            this.colAuthorID,
            this.colReleased,
            this.colReleasedID,
            this.colPublisher,
            this.colPublisherID,
            this.colNumberPage,
            this.colWeight,
            this.colForm,
            this.colPublishDate,
            this.colBuys,
            this.colPrice,
            this.colPromotionPrice,
            this.colCategory,
            this.colCategoryID,
            this.colViewCount,
            this.colLikeCount,
            this.colInventory,
            this.colStatus,
            this.colImage,
            this.colDescription,
            this.colModifiedDate,
            this.colModifiedBy});
               this.gridviewBook.GridControl = this.gridctrlBook;
               this.gridviewBook.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
               this.gridviewBook.Name = "gridviewBook";
               this.gridviewBook.OptionsView.ColumnAutoWidth = false;
               this.gridviewBook.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridviewBook_ForcusedRowChanged);
               // 
               // label6
               // 
               this.label6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.Location = new System.Drawing.Point(776, 0);
               this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(216, 56);
               this.label6.TabIndex = 6;
               this.label6.Text = "List Book";
               this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // txtbCode
               // 
               this.txtbCode.Location = new System.Drawing.Point(134, 80);
               this.txtbCode.Name = "txtbCode";
               this.txtbCode.Size = new System.Drawing.Size(323, 22);
               this.txtbCode.TabIndex = 7;
               // 
               // txtboxName
               // 
               this.txtboxName.Location = new System.Drawing.Point(134, 108);
               this.txtboxName.Name = "txtboxName";
               this.txtboxName.Size = new System.Drawing.Size(323, 22);
               this.txtboxName.TabIndex = 7;
               // 
               // cmbboxAuthor
               // 
               this.cmbboxAuthor.DataSource = this.authorViewModelBindingSource;
               this.cmbboxAuthor.DisplayMember = "Name";
               this.cmbboxAuthor.FormattingEnabled = true;
               this.cmbboxAuthor.Location = new System.Drawing.Point(134, 137);
               this.cmbboxAuthor.Name = "cmbboxAuthor";
               this.cmbboxAuthor.Size = new System.Drawing.Size(323, 24);
               this.cmbboxAuthor.TabIndex = 8;
               this.cmbboxAuthor.ValueMember = "ID";
               // 
               // authorViewModelBindingSource
               // 
               this.authorViewModelBindingSource.DataSource = typeof(AppQuanLy.Models.AuthorViewModel);
               // 
               // cmbboxRealeased
               // 
               this.cmbboxRealeased.DataSource = this.publisherBindingSource;
               this.cmbboxRealeased.DisplayMember = "Name";
               this.cmbboxRealeased.FormattingEnabled = true;
               this.cmbboxRealeased.Location = new System.Drawing.Point(134, 167);
               this.cmbboxRealeased.Name = "cmbboxRealeased";
               this.cmbboxRealeased.Size = new System.Drawing.Size(323, 24);
               this.cmbboxRealeased.TabIndex = 8;
               this.cmbboxRealeased.ValueMember = "ID";
               // 
               // publisherBindingSource
               // 
               this.publisherBindingSource.DataSource = typeof(AppQuanLy.Entities.Publisher);
               // 
               // cmbboxPublisher
               // 
               this.cmbboxPublisher.DataSource = this.publisherBindingSource;
               this.cmbboxPublisher.DisplayMember = "Name";
               this.cmbboxPublisher.FormattingEnabled = true;
               this.cmbboxPublisher.Location = new System.Drawing.Point(134, 197);
               this.cmbboxPublisher.Name = "cmbboxPublisher";
               this.cmbboxPublisher.Size = new System.Drawing.Size(323, 24);
               this.cmbboxPublisher.TabIndex = 8;
               this.cmbboxPublisher.ValueMember = "ID";
               // 
               // cmbboxCategory
               // 
               this.cmbboxCategory.DataSource = this.bookCategoryBindingSource;
               this.cmbboxCategory.DisplayMember = "Name";
               this.cmbboxCategory.FormattingEnabled = true;
               this.cmbboxCategory.Location = new System.Drawing.Point(133, 227);
               this.cmbboxCategory.Name = "cmbboxCategory";
               this.cmbboxCategory.Size = new System.Drawing.Size(324, 24);
               this.cmbboxCategory.TabIndex = 8;
               this.cmbboxCategory.ValueMember = "ID";
               // 
               // bookCategoryBindingSource
               // 
               this.bookCategoryBindingSource.DataSource = typeof(AppQuanLy.Entities.BookCategory);
               // 
               // txtbNumberPage
               // 
               this.txtbNumberPage.Location = new System.Drawing.Point(134, 257);
               this.txtbNumberPage.Name = "txtbNumberPage";
               this.txtbNumberPage.Size = new System.Drawing.Size(323, 22);
               this.txtbNumberPage.TabIndex = 7;
               // 
               // txtbWeight
               // 
               this.txtbWeight.Location = new System.Drawing.Point(134, 285);
               this.txtbWeight.Name = "txtbWeight";
               this.txtbWeight.Size = new System.Drawing.Size(323, 22);
               this.txtbWeight.TabIndex = 7;
               // 
               // txtbPrice
               // 
               this.txtbPrice.Location = new System.Drawing.Point(599, 87);
               this.txtbPrice.Name = "txtbPrice";
               this.txtbPrice.Size = new System.Drawing.Size(297, 22);
               this.txtbPrice.TabIndex = 7;
               // 
               // txtbImage
               // 
               this.txtbImage.Location = new System.Drawing.Point(599, 115);
               this.txtbImage.Name = "txtbImage";
               this.txtbImage.Size = new System.Drawing.Size(297, 22);
               this.txtbImage.TabIndex = 7;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(42, 84);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(41, 17);
               this.label1.TabIndex = 9;
               this.label1.Text = "Code";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(42, 111);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(45, 17);
               this.label2.TabIndex = 9;
               this.label2.Text = "Name";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(42, 140);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(50, 17);
               this.label3.TabIndex = 9;
               this.label3.Text = "Author";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(42, 170);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(68, 17);
               this.label4.TabIndex = 9;
               this.label4.Text = "Released";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(42, 201);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(67, 17);
               this.label5.TabIndex = 9;
               this.label5.Text = "Publisher";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Location = new System.Drawing.Point(39, 261);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(91, 17);
               this.label7.TabIndex = 9;
               this.label7.Text = "NumberPage";
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Location = new System.Drawing.Point(39, 288);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(52, 17);
               this.label8.TabIndex = 9;
               this.label8.Text = "Weight";
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Location = new System.Drawing.Point(543, 90);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(40, 17);
               this.label9.TabIndex = 9;
               this.label9.Text = "Price";
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.Location = new System.Drawing.Point(543, 120);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(46, 17);
               this.label10.TabIndex = 9;
               this.label10.Text = "Image";
               // 
               // label11
               // 
               this.label11.AutoSize = true;
               this.label11.Location = new System.Drawing.Point(41, 231);
               this.label11.Name = "label11";
               this.label11.Size = new System.Drawing.Size(65, 17);
               this.label11.TabIndex = 9;
               this.label11.Text = "Category";
               // 
               // txtbDescription
               // 
               this.txtbDescription.Location = new System.Drawing.Point(987, 84);
               this.txtbDescription.Multiline = true;
               this.txtbDescription.Name = "txtbDescription";
               this.txtbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
               this.txtbDescription.Size = new System.Drawing.Size(632, 223);
               this.txtbDescription.TabIndex = 7;
               // 
               // label12
               // 
               this.label12.AutoSize = true;
               this.label12.Location = new System.Drawing.Point(902, 87);
               this.label12.Name = "label12";
               this.label12.Size = new System.Drawing.Size(79, 17);
               this.label12.TabIndex = 9;
               this.label12.Text = "Description";
               // 
               // btnAdd
               // 
               this.btnAdd.Location = new System.Drawing.Point(1625, 109);
               this.btnAdd.Name = "btnAdd";
               this.btnAdd.Size = new System.Drawing.Size(91, 23);
               this.btnAdd.TabIndex = 10;
               this.btnAdd.Text = "Add";
               this.btnAdd.UseVisualStyleBackColor = true;
               this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
               // 
               // btnEdit
               // 
               this.btnEdit.Location = new System.Drawing.Point(1625, 138);
               this.btnEdit.Name = "btnEdit";
               this.btnEdit.Size = new System.Drawing.Size(91, 23);
               this.btnEdit.TabIndex = 10;
               this.btnEdit.Text = "Edit";
               this.btnEdit.UseVisualStyleBackColor = true;
               // 
               // btnSave
               // 
               this.btnSave.Location = new System.Drawing.Point(1625, 168);
               this.btnSave.Name = "btnSave";
               this.btnSave.Size = new System.Drawing.Size(91, 23);
               this.btnSave.TabIndex = 10;
               this.btnSave.Text = "Save";
               this.btnSave.UseVisualStyleBackColor = true;
               // 
               // btnDelete
               // 
               this.btnDelete.Location = new System.Drawing.Point(1625, 198);
               this.btnDelete.Name = "btnDelete";
               this.btnDelete.Size = new System.Drawing.Size(91, 23);
               this.btnDelete.TabIndex = 10;
               this.btnDelete.Text = "Delete";
               this.btnDelete.UseVisualStyleBackColor = true;
               // 
               // picboxImage
               // 
               this.picboxImage.Location = new System.Drawing.Point(546, 140);
               this.picboxImage.Name = "picboxImage";
               this.picboxImage.Size = new System.Drawing.Size(435, 167);
               this.picboxImage.TabIndex = 11;
               this.picboxImage.TabStop = false;
               // 
               // colID
               // 
               this.colID.FieldName = "ID";
               this.colID.Name = "colID";
               this.colID.Visible = true;
               this.colID.VisibleIndex = 0;
               this.colID.Width = 46;
               // 
               // colCode
               // 
               this.colCode.FieldName = "Code";
               this.colCode.Name = "colCode";
               this.colCode.Visible = true;
               this.colCode.VisibleIndex = 1;
               this.colCode.Width = 79;
               // 
               // colName
               // 
               this.colName.FieldName = "Name";
               this.colName.Name = "colName";
               this.colName.Visible = true;
               this.colName.VisibleIndex = 2;
               this.colName.Width = 108;
               // 
               // colAuthor
               // 
               this.colAuthor.FieldName = "Author";
               this.colAuthor.Name = "colAuthor";
               this.colAuthor.Visible = true;
               this.colAuthor.VisibleIndex = 3;
               this.colAuthor.Width = 123;
               // 
               // colAuthorID
               // 
               this.colAuthorID.FieldName = "AuthorID";
               this.colAuthorID.Name = "colAuthorID";
               // 
               // colReleased
               // 
               this.colReleased.FieldName = "Released";
               this.colReleased.Name = "colReleased";
               this.colReleased.Visible = true;
               this.colReleased.VisibleIndex = 4;
               this.colReleased.Width = 137;
               // 
               // colReleasedID
               // 
               this.colReleasedID.FieldName = "ReleasedID";
               this.colReleasedID.Name = "colReleasedID";
               // 
               // colPublisher
               // 
               this.colPublisher.FieldName = "Publisher";
               this.colPublisher.Name = "colPublisher";
               this.colPublisher.Visible = true;
               this.colPublisher.VisibleIndex = 5;
               this.colPublisher.Width = 129;
               // 
               // colPublisherID
               // 
               this.colPublisherID.FieldName = "PublisherID";
               this.colPublisherID.Name = "colPublisherID";
               // 
               // colNumberPage
               // 
               this.colNumberPage.FieldName = "NumberPage";
               this.colNumberPage.Name = "colNumberPage";
               this.colNumberPage.Visible = true;
               this.colNumberPage.VisibleIndex = 6;
               this.colNumberPage.Width = 80;
               // 
               // colWeight
               // 
               this.colWeight.FieldName = "Weight";
               this.colWeight.Name = "colWeight";
               this.colWeight.Visible = true;
               this.colWeight.VisibleIndex = 7;
               // 
               // colForm
               // 
               this.colForm.FieldName = "Form";
               this.colForm.Name = "colForm";
               this.colForm.Visible = true;
               this.colForm.VisibleIndex = 8;
               // 
               // colPublishDate
               // 
               this.colPublishDate.FieldName = "PublishDate";
               this.colPublishDate.Name = "colPublishDate";
               this.colPublishDate.Visible = true;
               this.colPublishDate.VisibleIndex = 9;
               this.colPublishDate.Width = 108;
               // 
               // colBuys
               // 
               this.colBuys.FieldName = "Buys";
               this.colBuys.Name = "colBuys";
               this.colBuys.Visible = true;
               this.colBuys.VisibleIndex = 10;
               // 
               // colPrice
               // 
               this.colPrice.FieldName = "Price";
               this.colPrice.Name = "colPrice";
               this.colPrice.Visible = true;
               this.colPrice.VisibleIndex = 11;
               // 
               // colPromotionPrice
               // 
               this.colPromotionPrice.FieldName = "PromotionPrice";
               this.colPromotionPrice.Name = "colPromotionPrice";
               this.colPromotionPrice.Visible = true;
               this.colPromotionPrice.VisibleIndex = 12;
               this.colPromotionPrice.Width = 117;
               // 
               // colCategory
               // 
               this.colCategory.FieldName = "Category";
               this.colCategory.Name = "colCategory";
               this.colCategory.Visible = true;
               this.colCategory.VisibleIndex = 13;
               this.colCategory.Width = 106;
               // 
               // colCategoryID
               // 
               this.colCategoryID.FieldName = "CategoryID";
               this.colCategoryID.Name = "colCategoryID";
               // 
               // colViewCount
               // 
               this.colViewCount.FieldName = "ViewCount";
               this.colViewCount.Name = "colViewCount";
               this.colViewCount.Visible = true;
               this.colViewCount.VisibleIndex = 14;
               // 
               // colLikeCount
               // 
               this.colLikeCount.FieldName = "LikeCount";
               this.colLikeCount.Name = "colLikeCount";
               // 
               // colInventory
               // 
               this.colInventory.FieldName = "Inventory";
               this.colInventory.Name = "colInventory";
               this.colInventory.Visible = true;
               this.colInventory.VisibleIndex = 15;
               // 
               // colStatus
               // 
               this.colStatus.FieldName = "Status";
               this.colStatus.Name = "colStatus";
               this.colStatus.Visible = true;
               this.colStatus.VisibleIndex = 20;
               // 
               // colImage
               // 
               this.colImage.FieldName = "Image";
               this.colImage.Name = "colImage";
               this.colImage.Visible = true;
               this.colImage.VisibleIndex = 16;
               // 
               // colDescription
               // 
               this.colDescription.FieldName = "Description";
               this.colDescription.Name = "colDescription";
               this.colDescription.Visible = true;
               this.colDescription.VisibleIndex = 17;
               // 
               // colModifiedDate
               // 
               this.colModifiedDate.FieldName = "ModifiedDate";
               this.colModifiedDate.Name = "colModifiedDate";
               this.colModifiedDate.Visible = true;
               this.colModifiedDate.VisibleIndex = 18;
               this.colModifiedDate.Width = 112;
               // 
               // colModifiedBy
               // 
               this.colModifiedBy.FieldName = "ModifiedBy";
               this.colModifiedBy.Name = "colModifiedBy";
               this.colModifiedBy.Visible = true;
               this.colModifiedBy.VisibleIndex = 19;
               this.colModifiedBy.Width = 104;
               // 
               // BooksUC
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.picboxImage);
               this.Controls.Add(this.btnDelete);
               this.Controls.Add(this.btnSave);
               this.Controls.Add(this.btnEdit);
               this.Controls.Add(this.btnAdd);
               this.Controls.Add(this.label11);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label10);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label12);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.cmbboxCategory);
               this.Controls.Add(this.cmbboxPublisher);
               this.Controls.Add(this.cmbboxRealeased);
               this.Controls.Add(this.cmbboxAuthor);
               this.Controls.Add(this.txtbImage);
               this.Controls.Add(this.txtbPrice);
               this.Controls.Add(this.txtbWeight);
               this.Controls.Add(this.txtbNumberPage);
               this.Controls.Add(this.txtboxName);
               this.Controls.Add(this.txtbDescription);
               this.Controls.Add(this.txtbCode);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.gridctrlBook);
               this.Name = "BooksUC";
               this.Size = new System.Drawing.Size(1944, 825);
               ((System.ComponentModel.ISupportInitialize)(this.gridctrlBook)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.bookViewModelBindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.gridviewBook)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.authorViewModelBindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.publisherBindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.bookCategoryBindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private DevExpress.XtraGrid.GridControl gridctrlBook;
          private DevExpress.XtraGrid.Views.Grid.GridView gridviewBook;
          private DevExpress.XtraGrid.Columns.GridColumn _Name;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.TextBox txtbCode;
          private System.Windows.Forms.TextBox txtboxName;
          private System.Windows.Forms.ComboBox cmbboxAuthor;
          private System.Windows.Forms.ComboBox cmbboxRealeased;
          private System.Windows.Forms.ComboBox cmbboxPublisher;
          private System.Windows.Forms.ComboBox cmbboxCategory;
          private System.Windows.Forms.TextBox txtbNumberPage;
          private System.Windows.Forms.TextBox txtbWeight;
          private System.Windows.Forms.TextBox txtbPrice;
          private System.Windows.Forms.TextBox txtbImage;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.Label label7;
          private System.Windows.Forms.Label label8;
          private System.Windows.Forms.Label label9;
          private System.Windows.Forms.Label label10;
          private System.Windows.Forms.Label label11;
          private System.Windows.Forms.TextBox txtbDescription;
          private System.Windows.Forms.Label label12;
          private System.Windows.Forms.Button btnAdd;
          private System.Windows.Forms.Button btnEdit;
          private System.Windows.Forms.Button btnSave;
          private System.Windows.Forms.Button btnDelete;
          private System.Windows.Forms.PictureBox picboxImage;
          private System.Windows.Forms.BindingSource bookViewModelBindingSource;
          private System.Windows.Forms.BindingSource authorViewModelBindingSource;
          private System.Windows.Forms.BindingSource publisherBindingSource;
          private System.Windows.Forms.BindingSource bookCategoryBindingSource;
          private DevExpress.XtraGrid.Columns.GridColumn colID;
          private DevExpress.XtraGrid.Columns.GridColumn colCode;
          private DevExpress.XtraGrid.Columns.GridColumn colName;
          private DevExpress.XtraGrid.Columns.GridColumn colAuthor;
          private DevExpress.XtraGrid.Columns.GridColumn colAuthorID;
          private DevExpress.XtraGrid.Columns.GridColumn colReleased;
          private DevExpress.XtraGrid.Columns.GridColumn colReleasedID;
          private DevExpress.XtraGrid.Columns.GridColumn colPublisher;
          private DevExpress.XtraGrid.Columns.GridColumn colPublisherID;
          private DevExpress.XtraGrid.Columns.GridColumn colNumberPage;
          private DevExpress.XtraGrid.Columns.GridColumn colWeight;
          private DevExpress.XtraGrid.Columns.GridColumn colForm;
          private DevExpress.XtraGrid.Columns.GridColumn colPublishDate;
          private DevExpress.XtraGrid.Columns.GridColumn colBuys;
          private DevExpress.XtraGrid.Columns.GridColumn colPrice;
          private DevExpress.XtraGrid.Columns.GridColumn colPromotionPrice;
          private DevExpress.XtraGrid.Columns.GridColumn colCategory;
          private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
          private DevExpress.XtraGrid.Columns.GridColumn colViewCount;
          private DevExpress.XtraGrid.Columns.GridColumn colLikeCount;
          private DevExpress.XtraGrid.Columns.GridColumn colInventory;
          private DevExpress.XtraGrid.Columns.GridColumn colStatus;
          private DevExpress.XtraGrid.Columns.GridColumn colImage;
          private DevExpress.XtraGrid.Columns.GridColumn colDescription;
          private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
          private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
     }
}
