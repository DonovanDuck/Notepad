using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Text_model;
using noteBook;

namespace NoteBook
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
        private User user;
        public static Text text;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItemCreat;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem25;
		private System.Windows.Forms.MenuItem menuItem31;
		private System.Windows.Forms.MenuItem menuItemOpen;
		private System.Windows.Forms.MenuItem menuItemSave;
		private System.Windows.Forms.MenuItem menuItemResave;
		private System.Windows.Forms.MenuItem menuItemDesign;
		private System.Windows.Forms.MenuItem menuItem1Print;
		private System.Windows.Forms.MenuItem menuItem1Exit;
		private System.Windows.Forms.MenuItem menuItem1Undo;
		private System.Windows.Forms.MenuItem menuItem1Cut;
		private System.Windows.Forms.MenuItem menuItem1Copy;
		private System.Windows.Forms.MenuItem menuItem1Past;
		private System.Windows.Forms.MenuItem menuItem1Delet;
		private System.Windows.Forms.MenuItem menuItemFind;
		private System.Windows.Forms.MenuItem menuItemNext;
		private System.Windows.Forms.MenuItem menuItemReplace;
		private System.Windows.Forms.MenuItem menuItemTurnTo;
		private System.Windows.Forms.MenuItem menuItemAll;
		private System.Windows.Forms.MenuItem menuItemTime;
		private System.Windows.Forms.MenuItem menuItemEnter;
		private System.Windows.Forms.MenuItem menuItemFront;
		private System.Windows.Forms.MenuItem menuItemHelp;
		private System.Windows.Forms.MenuItem menuItemAbout;
		public  System.Windows.Forms.RichTextBox richTextBox;//因为Form3要用到，所以不可设置为私有类，需设置为公有类
		private System.Windows.Forms.FontDialog fontDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog;
		private System.Drawing.Printing.PrintDocument printDocument;
		private System.Windows.Forms.PrintDialog printDialog;
		private System.Windows.Forms.ContextMenu contextMenu;
		private System.Windows.Forms.MenuItem contexMenuItemUndo;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem contexMenuItemCut;
		private System.Windows.Forms.MenuItem contexMenuItemCopy;
		private System.Windows.Forms.MenuItem contexMenuItemPast;
		private System.Windows.Forms.MenuItem contexMenuItemDel;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem contexMenuItemAll;
		private frmSearch form3;
		private frmReplace form4;
		private frmTurn form5;
        private frmmuntree form6;
        private frmsave form7;

//		程序需要自加的变量
        public static bool needToSave;
		private string currentFileName;
		StringReader strReader;
        private IContainer components;

        public frmMain(User user)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			needToSave=false;
			currentFileName=null;
			form3=new frmSearch();
			form3.Owner=this;//需设置，否则查找窗体找不到它的主窗体
			form4=new frmReplace();
			form4.Owner=this;
			form5=new frmTurn();
			form5.Owner=this;
            this.user = user;

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItemCreat = new System.Windows.Forms.MenuItem();
            this.menuItemOpen = new System.Windows.Forms.MenuItem();
            this.menuItemSave = new System.Windows.Forms.MenuItem();
            this.menuItemResave = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItemDesign = new System.Windows.Forms.MenuItem();
            this.menuItem1Print = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem1Exit = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem1Undo = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem1Cut = new System.Windows.Forms.MenuItem();
            this.menuItem1Copy = new System.Windows.Forms.MenuItem();
            this.menuItem1Past = new System.Windows.Forms.MenuItem();
            this.menuItem1Delet = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItemFind = new System.Windows.Forms.MenuItem();
            this.menuItemNext = new System.Windows.Forms.MenuItem();
            this.menuItemReplace = new System.Windows.Forms.MenuItem();
            this.menuItemTurnTo = new System.Windows.Forms.MenuItem();
            this.menuItem25 = new System.Windows.Forms.MenuItem();
            this.menuItemAll = new System.Windows.Forms.MenuItem();
            this.menuItemTime = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItemEnter = new System.Windows.Forms.MenuItem();
            this.menuItemFront = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItemHelp = new System.Windows.Forms.MenuItem();
            this.menuItem31 = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.contexMenuItemUndo = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.contexMenuItemCut = new System.Windows.Forms.MenuItem();
            this.contexMenuItemCopy = new System.Windows.Forms.MenuItem();
            this.contexMenuItemPast = new System.Windows.Forms.MenuItem();
            this.contexMenuItemDel = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.contexMenuItemAll = new System.Windows.Forms.MenuItem();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemCreat,
            this.menuItemOpen,
            this.menuItemSave,
            this.menuItemResave,
            this.menuItem9,
            this.menuItemDesign,
            this.menuItem1Print,
            this.menuItem12,
            this.menuItem1Exit});
            this.menuItem1.Text = "文件（&F)";
            // 
            // menuItemCreat
            // 
            this.menuItemCreat.Index = 0;
            this.menuItemCreat.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuItemCreat.Text = "新建(&N)";
            this.menuItemCreat.Click += new System.EventHandler(this.menuItemCreat_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Index = 1;
            this.menuItemOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuItemOpen.Text = "打开(&O)...";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Index = 2;
            this.menuItemSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuItemSave.Text = "保存(&S)";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // menuItemResave
            // 
            this.menuItemResave.Index = 3;
            this.menuItemResave.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.menuItemResave.Text = "另存为(&A)...";
            this.menuItemResave.Click += new System.EventHandler(this.menuItemResave_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 4;
            this.menuItem9.Text = "-";
            // 
            // menuItemDesign
            // 
            this.menuItemDesign.Index = 5;
            this.menuItemDesign.Shortcut = System.Windows.Forms.Shortcut.CtrlU;
            this.menuItemDesign.Text = "页面设置(&U)...";
            this.menuItemDesign.Click += new System.EventHandler(this.menuItemDesign_Click);
            // 
            // menuItem1Print
            // 
            this.menuItem1Print.Index = 6;
            this.menuItem1Print.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.menuItem1Print.Text = "打印(&P)...";
            this.menuItem1Print.Click += new System.EventHandler(this.menuItem1Print_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 7;
            this.menuItem12.Text = "-";
            // 
            // menuItem1Exit
            // 
            this.menuItem1Exit.Index = 8;
            this.menuItem1Exit.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.menuItem1Exit.Text = "退出(&X)";
            this.menuItem1Exit.Click += new System.EventHandler(this.menuItem1Exit_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1Undo,
            this.menuItem15,
            this.menuItem1Cut,
            this.menuItem1Copy,
            this.menuItem1Past,
            this.menuItem1Delet,
            this.menuItem20,
            this.menuItemFind,
            this.menuItemNext,
            this.menuItemReplace,
            this.menuItemTurnTo,
            this.menuItem25,
            this.menuItemAll,
            this.menuItemTime});
            this.menuItem2.Text = "编辑(&E)";
            this.menuItem2.Popup += new System.EventHandler(this.menuItem2_Popup);
            // 
            // menuItem1Undo
            // 
            this.menuItem1Undo.Index = 0;
            this.menuItem1Undo.Shortcut = System.Windows.Forms.Shortcut.CtrlU;
            this.menuItem1Undo.Text = "撤销(&U)";
            this.menuItem1Undo.Click += new System.EventHandler(this.menuItem1Undo_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 1;
            this.menuItem15.Text = "-";
            // 
            // menuItem1Cut
            // 
            this.menuItem1Cut.Enabled = false;
            this.menuItem1Cut.Index = 2;
            this.menuItem1Cut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.menuItem1Cut.Text = "剪切(&X)";
            this.menuItem1Cut.Click += new System.EventHandler(this.menuItem1Cut_Click);
            // 
            // menuItem1Copy
            // 
            this.menuItem1Copy.Enabled = false;
            this.menuItem1Copy.Index = 3;
            this.menuItem1Copy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.menuItem1Copy.Text = "复制(&C)";
            this.menuItem1Copy.Click += new System.EventHandler(this.menuItem1Copy_Click);
            // 
            // menuItem1Past
            // 
            this.menuItem1Past.Index = 4;
            this.menuItem1Past.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.menuItem1Past.Text = "粘贴(&V)";
            this.menuItem1Past.Click += new System.EventHandler(this.menuItem1Past_Click);
            // 
            // menuItem1Delet
            // 
            this.menuItem1Delet.Enabled = false;
            this.menuItem1Delet.Index = 5;
            this.menuItem1Delet.Shortcut = System.Windows.Forms.Shortcut.CtrlD;
            this.menuItem1Delet.Text = "删除(&D)";
            this.menuItem1Delet.Click += new System.EventHandler(this.menuItem1Delet_Click);
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 6;
            this.menuItem20.Text = "-";
            // 
            // menuItemFind
            // 
            this.menuItemFind.Index = 7;
            this.menuItemFind.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.menuItemFind.Text = "查找(&F)...";
            this.menuItemFind.Click += new System.EventHandler(this.menuItemFind_Click);
            // 
            // menuItemNext
            // 
            this.menuItemNext.Index = 8;
            this.menuItemNext.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuItemNext.Text = "查找下一个(&N)";
            this.menuItemNext.Click += new System.EventHandler(this.menuItemNext_Click);
            // 
            // menuItemReplace
            // 
            this.menuItemReplace.Index = 9;
            this.menuItemReplace.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.menuItemReplace.Text = "替换(&R)...";
            this.menuItemReplace.Click += new System.EventHandler(this.menuItemReplace_Click);
            // 
            // menuItemTurnTo
            // 
            this.menuItemTurnTo.Index = 10;
            this.menuItemTurnTo.Shortcut = System.Windows.Forms.Shortcut.CtrlG;
            this.menuItemTurnTo.Text = "转到(&G)...";
            this.menuItemTurnTo.Click += new System.EventHandler(this.menuItemTurnTo_Click);
            // 
            // menuItem25
            // 
            this.menuItem25.Index = 11;
            this.menuItem25.Text = "-";
            // 
            // menuItemAll
            // 
            this.menuItemAll.Index = 12;
            this.menuItemAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.menuItemAll.Text = "全选(&A)";
            this.menuItemAll.Click += new System.EventHandler(this.menuItemAll_Click);
            // 
            // menuItemTime
            // 
            this.menuItemTime.Index = 13;
            this.menuItemTime.Shortcut = System.Windows.Forms.Shortcut.CtrlD;
            this.menuItemTime.Text = "时间/日期((&D)";
            this.menuItemTime.Click += new System.EventHandler(this.menuItemTime_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemEnter,
            this.menuItemFront});
            this.menuItem3.Text = "格式（&O）";
            // 
            // menuItemEnter
            // 
            this.menuItemEnter.Index = 0;
            this.menuItemEnter.Shortcut = System.Windows.Forms.Shortcut.CtrlW;
            this.menuItemEnter.Text = "*自动换行(&W)";
            this.menuItemEnter.Click += new System.EventHandler(this.menuItemEnter_Click);
            // 
            // menuItemFront
            // 
            this.menuItemFront.Index = 1;
            this.menuItemFront.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.menuItemFront.Text = "字体(&F)...";
            this.menuItemFront.Click += new System.EventHandler(this.menuItemFront_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemHelp,
            this.menuItem31,
            this.menuItemAbout});
            this.menuItem4.Text = "云";
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Index = 0;
            this.menuItemHelp.Shortcut = System.Windows.Forms.Shortcut.CtrlH;
            this.menuItemHelp.Text = "我的笔记";
            this.menuItemHelp.Click += new System.EventHandler(this.menuItem30_Click);
            // 
            // menuItem31
            // 
            this.menuItem31.Index = 1;
            this.menuItem31.Text = "-";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 2;
            this.menuItemAbout.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.menuItemAbout.Text = "存云端";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItem32_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox.ContextMenu = this.contextMenu;
            this.richTextBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(712, 424);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // contextMenu
            // 
            this.contextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.contexMenuItemUndo,
            this.menuItem6,
            this.contexMenuItemCut,
            this.contexMenuItemCopy,
            this.contexMenuItemPast,
            this.contexMenuItemDel,
            this.menuItem13,
            this.contexMenuItemAll});
            this.contextMenu.Popup += new System.EventHandler(this.contextMenu_Popup);
            // 
            // contexMenuItemUndo
            // 
            this.contexMenuItemUndo.Index = 0;
            this.contexMenuItemUndo.Text = "撤销(&U)";
            this.contexMenuItemUndo.Click += new System.EventHandler(this.contexMenuItemUndo_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "-";
            // 
            // contexMenuItemCut
            // 
            this.contexMenuItemCut.Index = 2;
            this.contexMenuItemCut.Text = "剪切(&X)";
            this.contexMenuItemCut.Click += new System.EventHandler(this.contexMenuItemCut_Click);
            // 
            // contexMenuItemCopy
            // 
            this.contexMenuItemCopy.Index = 3;
            this.contexMenuItemCopy.Text = "复制(&C)";
            this.contexMenuItemCopy.Click += new System.EventHandler(this.contexMenuItemCopy_Click);
            // 
            // contexMenuItemPast
            // 
            this.contexMenuItemPast.Index = 4;
            this.contexMenuItemPast.Text = "粘贴(&V)";
            this.contexMenuItemPast.Click += new System.EventHandler(this.contexMenuItemPast_Click);
            // 
            // contexMenuItemDel
            // 
            this.contexMenuItemDel.Index = 5;
            this.contexMenuItemDel.Text = "删除(&D)";
            this.contexMenuItemDel.Click += new System.EventHandler(this.contexMenuItemDel_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 6;
            this.menuItem13.Text = "-";
            // 
            // contexMenuItemAll
            // 
            this.contexMenuItemAll.Index = 7;
            this.contexMenuItemAll.Text = "全选(&A)";
            this.contexMenuItemAll.Click += new System.EventHandler(this.contexMenuItemAll_Click);
            // 
            // fontDialog
            // 
            this.fontDialog.FontMustExist = true;
            this.fontDialog.ShowColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.txt";
            this.openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*|C#文件(*.cs)|*.cs";
            this.openFileDialog.Title = "打开";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "*.txt";
            this.saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*|C#文件(*.cs)|*.cs";
            this.saveFileDialog.Title = "保存文件";
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(712, 422);
            this.Controls.Add(this.richTextBox);
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.Text = "笔记本   你好：";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		//static void Main() 
		//{
		//	Application.Run(new frmMain());
		//}

		#region 自编函数，打开、保存方法
//		自编函数，打开、保存方法		
//		获取要打开的文件名
		private string GetOpenFile()
		{
			if(openFileDialog.ShowDialog()==DialogResult.OK)
				return openFileDialog.FileName;
			else
				return null;
		}
//		获取要保存文件名
		private string GetSaveFile()
		{
			if(saveFileDialog.ShowDialog()==DialogResult.OK)
				return saveFileDialog.FileName;
			else
				return null;
		}
//		打开文件函数
		private void OpenFile()
		{
			try
			{

					FileInfo fileInfo=new FileInfo(currentFileName);//用此函数时付给currentFileName为要打开的文件明，用GetOpenFile()
					StreamReader reader=fileInfo.OpenText();
					this.richTextBox.Text=reader.ReadToEnd();
					reader.Close();
					this.Text="文本编辑--"+fileInfo.Name;
				    needToSave=false;  //打开函数包含了刷新，即把richTextBox的更改标志定位初始值null

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			
			}
		}
//		保存文件函数
		private void SaveFile(string fileText)
		{
			try
			{				

					StreamWriter writer=new StreamWriter(currentFileName);//此处的currentFileName为要保存到的路径文件名，用之前要用GetSaveFile赋值
					writer.Write(fileText);
					writer.Close();
				    needToSave=false;

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				
			}
		}
		#endregion

		#region 云存储


		public void menuItem32_Click(object sender, System.EventArgs e)
		{
            user = new User();
            text = new Text();
            text.Content = this.richTextBox.Text;
            user.Username = "tom";
            form7 = new frmsave(user,text);
            form7.Owner = this;
            form7.Show();
           
        }
		
//		云-我的笔记
		private void menuItem30_Click(object sender, System.EventArgs e)
		{
            User user = new User();
            user.Username = "tom";
            form6 =   new frmmuntree(user);
            form6.Owner = this;
            form6.Show();
		}
		#endregion

		#region 格式

		//		自动换行
		private void menuItemEnter_Click(object sender, System.EventArgs e)
		{
			if(this.richTextBox.WordWrap==true)
			{
				this.richTextBox.WordWrap=false;
				this.menuItemEnter.Text="自动换行(&W)";
			}
			else
			{
				this.richTextBox.WordWrap=true;
				this.menuItemEnter.Text="*"+"自动换行("+"&"+"W)";
                				
			}
		}
		
//		字体
		private void menuItemFront_Click(object sender, System.EventArgs e)
		{
			FontDialog fontDialog=new FontDialog();
			fontDialog.ShowColor=true;
			
			if(fontDialog.ShowDialog()==DialogResult.OK)
			{
				richTextBox.SelectionFont=fontDialog.Font;
				richTextBox.SelectionColor=fontDialog.Color;
			
			}			
			
		}
		#endregion

		#region 编辑菜单1--复制、粘贴、删除等 

//		撤销
		private void menuItem1Undo_Click(object sender, System.EventArgs e)
		{
			if(this.richTextBox.CanUndo==true)
			{
				richTextBox.Undo();
				richTextBox.ClearUndo();
			}
		}
//在编辑菜单打开前启用，检查有些项是否启用
		private void menuItem2_Popup(object sender, System.EventArgs e)
		{
			if(richTextBox.SelectedText.Length>0)
			{
				this.menuItem1Copy.Enabled=true;
				this.menuItem1Cut.Enabled=true;
				this.menuItem1Delet.Enabled=true;

			}
			else
			{
				this.menuItem1Copy.Enabled=false;
				this.menuItem1Cut.Enabled=false;
				this.menuItem1Delet.Enabled=false;

			}

			if(richTextBox.CanUndo==true)
				this.menuItem1Undo.Enabled=true;
			else
				this.menuItem1Undo.Enabled=false;

			if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
				this.menuItem1Past.Enabled=true;
			else
				this.menuItem1Past.Enabled=false;
			if(this.richTextBox.Text.Length>0)
				this.menuItemTurnTo.Enabled=true;
			else
				this.menuItemTurnTo.Enabled=false;

		}

//      剪切
		private void menuItem1Cut_Click(object sender, System.EventArgs e)
		{
			if(this.menuItem1Cut.Enabled==true)
			{
				Clipboard.SetDataObject(richTextBox.SelectedText);
				richTextBox.SelectedText="";
			}


		}

//		复制
		private void menuItem1Copy_Click(object sender, System.EventArgs e)
		{
			if(this.menuItem1Copy.Enabled==true)
				Clipboard.SetDataObject(richTextBox.SelectedText);
		}

//		删除
		private void menuItem1Delet_Click(object sender, System.EventArgs e)
		{
			if(this.menuItem1Delet.Enabled==true)
				richTextBox.SelectedText="";
		}

//		粘贴
		private void menuItem1Past_Click(object sender, System.EventArgs e)
		{
			if(this.menuItem1Past.Enabled==true)
			{
				if(richTextBox.SelectedText.Length>0)
				{
					if(MessageBox.Show("确定真的要覆盖原有文本吗？","覆盖提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.No)
						richTextBox.SelectionStart=richTextBox.SelectionStart+richTextBox.SelectionLength;
					else
						richTextBox.Paste();
				}
				else
				    richTextBox.Paste();
			}
		}

//		全选
		private void menuItemAll_Click(object sender, System.EventArgs e)
		{
			this.richTextBox.SelectAll();
		}

//		显示日期和时间
		private void menuItemTime_Click(object sender, System.EventArgs e)
		{
			this.richTextBox.Text+=DateTime.Now;
		}

		#endregion

		#region 文件菜单
//		退出
		private void menuItem1Exit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

//		为文件的打开、保存、新建和关闭做提前准备--修改过的标志
		private void richTextBox_TextChanged(object sender, System.EventArgs e)
		{
			needToSave=true;
		}

//		关闭窗口前时的操作--提示是否保存
		private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(needToSave==true)
			{
				DialogResult result=MessageBox.Show("文件被修改过，是否需要保存?","保存提示",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
				if(result==DialogResult.Cancel)
					e.Cancel=true;
				if(result==DialogResult.Yes)				
					menuItemSave_Click(sender,e);				

			}
		}

//		保存菜单
		private void menuItemSave_Click(object sender, System.EventArgs e)
		{
			if(currentFileName==null)
				menuItemResave_Click(sender,e);
			else
				SaveFile(this.richTextBox.Text);
			needToSave=false;
		}

//		新建菜单
		private void menuItemCreat_Click(object sender, System.EventArgs e)
		{
			if(needToSave==true)
			{
				DialogResult result=MessageBox.Show("当前文件是否需要保存","保存提示",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
				switch(result)
				{
					case DialogResult.Cancel:
						break;
					case DialogResult.Yes:
					{
						menuItemSave_Click(sender,e);
						richTextBox.Clear();
						this.Text="文本编辑--新建文本";						
						break;
					}
					case DialogResult.No:
					{
						richTextBox.Clear();
						this.Text="文本编辑--新建文本";
						needToSave=false;
						break;
					}
				}
			}
			else
			{
				richTextBox.Clear();
				this.Text="文本编辑--新建文本";
				
			}
				
			
		}


//		打开菜单
		private void menuItemOpen_Click(object sender, System.EventArgs e)
		{
			if(needToSave==true)
			{
				DialogResult result=MessageBox.Show("当前文件是否需要保存","保存提示",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
				switch(result)
				{
					case DialogResult.Cancel:
						break;
					case DialogResult.Yes:
					{
						menuItemSave_Click(sender,e);
						currentFileName=GetOpenFile();
						OpenFile();								
						break;
					}
					case DialogResult.No:
					{
						currentFileName=GetOpenFile();
						OpenFile();							
						break;
					}
				}
			}
			else
			{
				currentFileName=GetOpenFile();
				OpenFile();				
			}
		}


//		另存为菜单
		private void menuItemResave_Click(object sender, System.EventArgs e)
		{					
			string fileName=GetSaveFile();
			if(fileName==null)
				return;
			else
			{
				currentFileName=fileName;
				SaveFile(this.richTextBox.Text);
			}
			
		}

//		页面设置菜单
		private void menuItemDesign_Click(object sender, System.EventArgs e)
		{

			pageSetupDialog.ShowDialog();
		}
		#endregion
		
		#region 快捷菜单
//		上下文快捷菜单某些项是否启用
		private void contextMenu_Popup(object sender, System.EventArgs e)
		{			
			menuItem2_Popup(sender,e);
		}

		
//		上下文快捷菜单
//		撤销
		private void contexMenuItemUndo_Click(object sender, System.EventArgs e)
		{
			menuItem1Undo_Click(null,null);
		}

//		剪切
		private void contexMenuItemCut_Click(object sender, System.EventArgs e)
		{
			menuItem1Cut_Click(null,null);

		}

//		复制
		private void contexMenuItemCopy_Click(object sender, System.EventArgs e)
		{
			menuItem1Copy_Click(null,null);
		}

//		粘贴
		private void contexMenuItemPast_Click(object sender, System.EventArgs e)
		{
			menuItem1Past_Click(null,null);
		}

//		删除
		private void contexMenuItemDel_Click(object sender, System.EventArgs e)
		{
			menuItem1Delet_Click(null,null);
		}

//		全选
		private void contexMenuItemAll_Click(object sender, System.EventArgs e)
		{
			menuItemAll_Click(null,null);
		}
		#endregion

		#region 编辑菜单2--查找、替换、跳转
//		查找
		private void menuItemFind_Click(object sender, System.EventArgs e)
		{			
			form3.Show();
			form3.Activate();
		}

//		查找下一个
		private void menuItemNext_Click(object sender, System.EventArgs e)
		{
			form3.btnSearch_Click(sender,e);
		}

//		替换
		private void menuItemReplace_Click(object sender, System.EventArgs e)
		{
			form4.Show();
			form4.Activate();
		}

//		转到		
		private void menuItemTurnTo_Click(object sender, System.EventArgs e)
		{
			form5.Show();
			form5.Activate();
		}
		#endregion

//		打印
		private void menuItem1Print_Click(object sender, System.EventArgs e)
		{
			strReader=new StringReader(this.richTextBox.Text);

			if(printDialog.ShowDialog()==DialogResult.OK)
				try
				{
					printDocument.Print();
				}
			    catch(Exception ex)
			    {
				    MessageBox.Show(ex.Message,"打印错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
					printDocument.PrintController.OnEndPrint(printDocument,new System.Drawing.Printing.PrintEventArgs());
			    }
		}

		private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Graphics graphics=e.Graphics;
			float linesPpage=0;
			int count=0;
			float yPosition=0;
			float leftMargin=e.MarginBounds.Left;
			float topMargin=e.MarginBounds.Top;
			string lineString=null;
			Font font=this.richTextBox.Font;
			SolidBrush brush=new SolidBrush(Color.Black);
			linesPpage=e.MarginBounds.Height/font.GetHeight(graphics);
			while(count<linesPpage&&(lineString=strReader.ReadLine())!=null)
			{
				yPosition=topMargin+(count*font.GetHeight(graphics));
				graphics.DrawString(lineString,font,brush,leftMargin,yPosition,new StringFormat());
				count++;
			}
			//			如果一页打印不完,把HasMorePage的属性设为true.
			if(lineString!=null)
			{
				e.HasMorePages=true;
			}
			else
			{
				e.HasMorePages=false;
			}

		}
	
				
	}
}
