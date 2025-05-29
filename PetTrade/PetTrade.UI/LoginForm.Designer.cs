using System;
using System.Windows.Forms;

namespace PetTrade.UI
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Text_UserId = new System.Windows.Forms.TextBox();
            this.Text_Password = new System.Windows.Forms.TextBox();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Label_UserId = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.Page_MyPet = new System.Windows.Forms.TabPage();
            this.ListView_MyPet = new System.Windows.Forms.ListView();
            this.PetId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PetType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaleStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Page_PetMarket = new System.Windows.Forms.TabPage();
            this.listView_PetMarket = new System.Windows.Forms.ListView();
            this.PetId1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PetName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PetType1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PetPossessor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl_Main.SuspendLayout();
            this.Page_MyPet.SuspendLayout();
            this.Page_PetMarket.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text_UserId
            // 
            this.Text_UserId.Location = new System.Drawing.Point(338, 130);
            this.Text_UserId.Name = "Text_UserId";
            this.Text_UserId.Size = new System.Drawing.Size(126, 21);
            this.Text_UserId.TabIndex = 0;
            // 
            // Text_Password
            // 
            this.Text_Password.Location = new System.Drawing.Point(338, 199);
            this.Text_Password.Name = "Text_Password";
            this.Text_Password.PasswordChar = '*';
            this.Text_Password.Size = new System.Drawing.Size(126, 21);
            this.Text_Password.TabIndex = 1;
            // 
            // Button_Login
            // 
            this.Button_Login.Location = new System.Drawing.Point(314, 259);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(90, 37);
            this.Button_Login.TabIndex = 2;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Label_UserId
            // 
            this.Label_UserId.AutoSize = true;
            this.Label_UserId.Location = new System.Drawing.Point(259, 133);
            this.Label_UserId.Name = "Label_UserId";
            this.Label_UserId.Size = new System.Drawing.Size(41, 12);
            this.Label_UserId.TabIndex = 3;
            this.Label_UserId.Text = "UserId";
            this.Label_UserId.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(259, 202);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(53, 12);
            this.Label_Password.TabIndex = 4;
            this.Label_Password.Text = "Password";
            this.Label_Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.Page_MyPet);
            this.tabControl_Main.Controls.Add(this.Page_PetMarket);
            this.tabControl_Main.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Main.Location = new System.Drawing.Point(-2, 3);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(790, 435);
            this.tabControl_Main.TabIndex = 5;
            this.tabControl_Main.Tag = "";
            this.tabControl_Main.Visible = false;
            this.tabControl_Main.SelectedIndexChanged += tabControl_Main_SelectedIndexChanged;
            
            // 
            // Page_MyPet
            // 
            this.Page_MyPet.Controls.Add(this.ListView_MyPet);
            this.Page_MyPet.Location = new System.Drawing.Point(4, 24);
            this.Page_MyPet.Name = "Page_MyPet";
            this.Page_MyPet.Padding = new System.Windows.Forms.Padding(3);
            this.Page_MyPet.Size = new System.Drawing.Size(782, 407);
            this.Page_MyPet.TabIndex = 0;
            this.Page_MyPet.Text = "My pet";
            this.Page_MyPet.UseVisualStyleBackColor = true;
            // 
            // ListView_MyPet
            // 
            this.ListView_MyPet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListView_MyPet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PetId,
            this.PetName,
            this.PetType,
            this.SaleStatus,
            this.Price});
            this.ListView_MyPet.HideSelection = false;
            this.ListView_MyPet.Location = new System.Drawing.Point(0, 0);
            this.ListView_MyPet.Name = "ListView_MyPet";
            this.ListView_MyPet.ShowItemToolTips = true;
            this.ListView_MyPet.Size = new System.Drawing.Size(782, 411);
            this.ListView_MyPet.TabIndex = 0;
            this.ListView_MyPet.UseCompatibleStateImageBehavior = false;
            this.ListView_MyPet.View = System.Windows.Forms.View.Details;
            this.ListView_MyPet.SelectedIndexChanged += new System.EventHandler(this.ListView_MyPet_SelectedIndexChanged);
            // 
            // PetId
            // 
            this.PetId.Tag = "";
            this.PetId.Text = "宠物Id";
            // 
            // PetName
            // 
            this.PetName.Text = "宠物名字";
            // 
            // PetType
            // 
            this.PetType.Text = "宠物类别";
            // 
            // SaleStatus
            // 
            this.SaleStatus.Text = "在售状态";
            // 
            // Price
            // 
            this.Price.Text = "价格";
            // 
            // Page_PetMarket
            // 
            this.Page_PetMarket.Controls.Add(this.listView_PetMarket);
            this.Page_PetMarket.Location = new System.Drawing.Point(4, 24);
            this.Page_PetMarket.Name = "Page_PetMarket";
            this.Page_PetMarket.Padding = new System.Windows.Forms.Padding(3);
            this.Page_PetMarket.Size = new System.Drawing.Size(782, 407);
            this.Page_PetMarket.TabIndex = 1;
            this.Page_PetMarket.Text = "Pet Market";
            this.Page_PetMarket.UseVisualStyleBackColor = true;
            this.Page_PetMarket.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // listView_PetMarket
            // 
            this.listView_PetMarket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PetId1,
            this.PetName1,
            this.PetType1,
            this.PetPossessor,
            this.Price1});
            this.listView_PetMarket.HideSelection = false;
            this.listView_PetMarket.Location = new System.Drawing.Point(0, 0);
            this.listView_PetMarket.Name = "listView_PetMarket";
            this.listView_PetMarket.Size = new System.Drawing.Size(782, 411);
            this.listView_PetMarket.TabIndex = 0;
            this.listView_PetMarket.UseCompatibleStateImageBehavior = false;
            this.listView_PetMarket.View = System.Windows.Forms.View.Details;
            // 
            // PetId1
            // 
            this.PetId1.Text = "宠物Id";
            // 
            // PetName1
            // 
            this.PetName1.Text = "宠物名字";
            // 
            // PetType1
            // 
            this.PetType1.Text = "宠物类型";
            // 
            // PetPossessor
            // 
            this.PetPossessor.Text = "宠物主人";
            // 
            // Price1
            // 
            this.Price1.Text = "价格";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_UserId);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.Text_Password);
            this.Controls.Add(this.Text_UserId);
            this.Name = "LoginForm";
            this.Text = "Pet Trade System";
            this.tabControl_Main.ResumeLayout(false);
            this.Page_MyPet.ResumeLayout(false);
            this.Page_PetMarket.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        private void tabControl_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_Main.SelectedTab == Page_MyPet)
            {
                RefreshPage_MyPet();
            }
            else if (tabControl_Main.SelectedTab == Page_PetMarket)
            {
                RefreshPage_PetMarketWithOutUser();
            }
        }

        #endregion

        private System.Windows.Forms.TextBox Text_UserId;
        private System.Windows.Forms.TextBox Text_Password;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Label Label_UserId;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage Page_MyPet;
        private System.Windows.Forms.TabPage Page_PetMarket;
        private System.Windows.Forms.ListView ListView_MyPet;
        private System.Windows.Forms.ColumnHeader PetId;
        private System.Windows.Forms.ColumnHeader PetName;
        private System.Windows.Forms.ColumnHeader PetType;
        private System.Windows.Forms.ColumnHeader SaleStatus;
        private System.Windows.Forms.ColumnHeader Price;
        private ListView listView_PetMarket;
        private ColumnHeader PetId1;
        private ColumnHeader PetName1;
        private ColumnHeader PetType1;
        private ColumnHeader PetPossessor;
        private ColumnHeader Price1;
    }
}

