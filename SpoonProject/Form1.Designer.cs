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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anywheather));
            this.Enter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.City = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Temp = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.CityDesc = new System.Windows.Forms.Label();
            this.TempF = new System.Windows.Forms.Label();
            this.Sunrise = new System.Windows.Forms.Label();
            this.Sunset = new System.Windows.Forms.Label();
            this.Response = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.Response.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.SystemColors.Highlight;
            this.Enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enter.Location = new System.Drawing.Point(412, 326);
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
            this.button1.Location = new System.Drawing.Point(541, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(126, 326);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(266, 23);
            this.City.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "City:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(13, 329);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(62, 15);
            this.Date.TabIndex = 4;
            this.Date.Text = "DateTime";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.Firebrick;
            this.Error.Location = new System.Drawing.Point(127, 308);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(124, 15);
            this.Error.TabIndex = 6;
            this.Error.Text = "City not found by API";
            this.Error.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 87);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solar Events";
            this.groupBox1.Visible = false;
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
            // CityDesc
            // 
            this.CityDesc.AutoSize = true;
            this.CityDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CityDesc.Location = new System.Drawing.Point(7, 0);
            this.CityDesc.Name = "CityDesc";
            this.CityDesc.Size = new System.Drawing.Size(76, 21);
            this.CityDesc.TabIndex = 3;
            this.CityDesc.Text = "CityDesc";
            this.CityDesc.Visible = false;
            // 
            // TempF
            // 
            this.TempF.AutoSize = true;
            this.TempF.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TempF.Location = new System.Drawing.Point(304, 60);
            this.TempF.Name = "TempF";
            this.TempF.Size = new System.Drawing.Size(119, 45);
            this.TempF.TabIndex = 4;
            this.TempF.Text = "TempF";
            this.TempF.Visible = false;
            // 
            // Sunrise
            // 
            this.Sunrise.AutoSize = true;
            this.Sunrise.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sunrise.Location = new System.Drawing.Point(24, 197);
            this.Sunrise.Name = "Sunrise";
            this.Sunrise.Size = new System.Drawing.Size(66, 21);
            this.Sunrise.TabIndex = 5;
            this.Sunrise.Text = "Sunrise";
            this.Sunrise.Visible = false;
            // 
            // Sunset
            // 
            this.Sunset.AutoSize = true;
            this.Sunset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sunset.Location = new System.Drawing.Point(24, 229);
            this.Sunset.Name = "Sunset";
            this.Sunset.Size = new System.Drawing.Size(61, 21);
            this.Sunset.TabIndex = 6;
            this.Sunset.Text = "Sunset";
            this.Sunset.Visible = false;
            // 
            // Response
            // 
            this.Response.Controls.Add(this.groupBox3);
            this.Response.Controls.Add(this.Sunset);
            this.Response.Controls.Add(this.Sunrise);
            this.Response.Controls.Add(this.TempF);
            this.Response.Controls.Add(this.Desc);
            this.Response.Controls.Add(this.Temp);
            this.Response.Controls.Add(this.Picture);
            this.Response.Controls.Add(this.groupBox1);
            this.Response.Controls.Add(this.groupBox2);
            this.Response.Controls.Add(this.pictureBox1);
            this.Response.Location = new System.Drawing.Point(23, 13);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(587, 292);
            this.Response.TabIndex = 5;
            this.Response.TabStop = false;
            this.Response.Text = "Weather Report";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(219, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 87);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pressure";
            this.groupBox3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CityDesc);
            this.groupBox2.Location = new System.Drawing.Point(12, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 154);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(552, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Anywheather
            // 
            this.AcceptButton = this.Enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(629, 359);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.City);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Anywheather";
            this.Text = "Anyweather";
            this.Load += new System.EventHandler(this.Anywheather_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.Response.ResumeLayout(false);
            this.Response.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button Enter;
    private Button button1;
    private TextBox City;
    private Label label1;
    private Label Date;
    private Label Error;
    private GroupBox groupBox1;
    private PictureBox Picture;
    private Label Temp;
    private Label Desc;
    private Label CityDesc;
    private Label TempF;
    private Label Sunrise;
    private Label Sunset;
    private GroupBox Response;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private Label label2;
    private PictureBox pictureBox1;
}