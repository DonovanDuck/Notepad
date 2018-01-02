using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace NoteBook
{
	/// <summary>
	/// frmTurn ��ժҪ˵����
	/// </summary>
	public class frmTurn : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label labTurn;
		private System.Windows.Forms.TextBox txtTurn;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancle;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTurn()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.labTurn = new System.Windows.Forms.Label();
			this.txtTurn = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labTurn
			// 
			this.labTurn.Location = new System.Drawing.Point(16, 16);
			this.labTurn.Name = "labTurn";
			this.labTurn.Size = new System.Drawing.Size(80, 24);
			this.labTurn.TabIndex = 0;
			this.labTurn.Text = "Ҫת��������";
			this.labTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtTurn
			// 
			this.txtTurn.Location = new System.Drawing.Point(104, 16);
			this.txtTurn.Name = "txtTurn";
			this.txtTurn.Size = new System.Drawing.Size(80, 21);
			this.txtTurn.TabIndex = 1;
			this.txtTurn.Text = "";
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(24, 56);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(56, 24);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "ȷ��";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancle
			// 
			this.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancle.Location = new System.Drawing.Point(120, 56);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(56, 24);
			this.btnCancle.TabIndex = 3;
			this.btnCancle.Text = "ȡ��";
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// frmTurn
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 14);
			this.CancelButton = this.btnCancle;
			this.ClientSize = new System.Drawing.Size(208, 94);
			this.Controls.Add(this.btnCancle);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.txtTurn);
			this.Controls.Add(this.labTurn);
			this.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTurn";
			this.Text = "ת��";
			this.ResumeLayout(false);

		}
		#endregion

//		ȡ��
		private void btnCancle_Click(object sender, System.EventArgs e)
		{
            this.Hide();		
		}

//		ȷ��
		private void btnOk_Click(object sender, System.EventArgs e)
		{	
			frmMain mainForm=(frmMain)this.Owner;
			int maxNum=mainForm.richTextBox.Lines.Length;//������ı�������			
			int selectNo=Int16.Parse(this.txtTurn.Text)-1;//Ҫ��ת������������ǰһ���س�����
			int findNo=0;  //�س�����
			int findPoint=0;//�������λ��
			
				if((selectNo+1)<=maxNum)
				{
					while(findNo<selectNo)
					{
						findPoint=mainForm.richTextBox.Text.IndexOf("\n",(findPoint+1));

						findNo+=1;
					}
				
					mainForm.richTextBox .Select((findPoint+1),0);//��ȥ�س�����ռ��λ��
				}
				else
					MessageBox.Show("����������Χ","������ʾ",MessageBoxButtons.OK,MessageBoxIcon.Warning);

				mainForm.Activate();			

		}
	}
}
