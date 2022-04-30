namespace SpoonProject;

partial class Anywheather
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.Enter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.City = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Response = new System.Windows.Forms.GroupBox();
            this.CityDesc = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Error = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Response.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.SystemColors.Highlight;
            this.Enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enter.Location = new System.Drawing.Point(410, 417);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(114, 23);
            this.Enter.TabIndex = 0;
            this.Enter.Text = "Get weather";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(539, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(124, 417);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(266, 23);
            this.City.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "City:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(11, 420);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(62, 15);
            this.Date.TabIndex = 4;
            this.Date.Text = "DateTime";
            // 
            // Response
            // 
            this.Response.Controls.Add(this.button2);
            this.Response.Controls.Add(this.CityDesc);
            this.Response.Controls.Add(this.Desc);
            this.Response.Controls.Add(this.Temp);
            this.Response.Controls.Add(this.Picture);
            this.Response.Location = new System.Drawing.Point(23, 13);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(587, 386);
            this.Response.TabIndex = 5;
            this.Response.TabStop = false;
            this.Response.Text = "Weather Report";
            // 
            // CityDesc
            // 
            this.CityDesc.AutoSize = true;
            this.CityDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CityDesc.Location = new System.Drawing.Point(8, 20);
            this.CityDesc.Name = "CityDesc";
            this.CityDesc.Size = new System.Drawing.Size(57, 21);
            this.CityDesc.TabIndex = 3;
            this.CityDesc.Text = "label2";
            this.CityDesc.Visible = false;
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Desc.Location = new System.Drawing.Point(163, 120);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(96, 21);
            this.Desc.TabIndex = 2;
            this.Desc.Text = "description";
            this.Desc.Visible = false;
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Temp.Location = new System.Drawing.Point(157, 60);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(102, 45);
            this.Temp.TabIndex = 1;
            this.Temp.Text = "Temp";
            this.Temp.Visible = false;
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(24, 60);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(127, 81);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            this.Picture.Visible = false;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.Firebrick;
            this.Error.Location = new System.Drawing.Point(125, 399);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(124, 15);
            this.Error.TabIndex = 6;
            this.Error.Text = "City not found by API";
            this.Error.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Anywheather
            // 
            this.AcceptButton = this.Enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(629, 451);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.City);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Enter);
            this.Name = "Anywheather";
            this.Text = "Anyweather";
            this.Load += new System.EventHandler(this.Anywheather_Load);
            this.Response.ResumeLayout(false);
            this.Response.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button Enter;
    private Button button1;
    private TextBox City;
    private Label label1;
    private Label Date;
    private GroupBox Response;
    private Label Temp;
    private PictureBox Picture;
    private Label Desc;
    private Label Error;
    private Label CityDesc;
    private Button button2;
}