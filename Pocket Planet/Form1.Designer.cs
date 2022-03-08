
namespace Pocket_Planet
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_message = new System.Windows.Forms.Label();
            this.lbl_mset = new System.Windows.Forms.Label();
            this.lbl_cset = new System.Windows.Forms.Label();
            this.lbl_set = new System.Windows.Forms.Label();
            this.rbtn_loadMap = new System.Windows.Forms.RadioButton();
            this.rbtn_generateMap = new System.Windows.Forms.RadioButton();
            this.cb_agressive = new System.Windows.Forms.CheckBox();
            this.cb_peacekeeper = new System.Windows.Forms.CheckBox();
            this.cb_green_movement = new System.Windows.Forms.CheckBox();
            this.cb_hard_terrain = new System.Windows.Forms.CheckBox();
            this.gb_map = new System.Windows.Forms.GroupBox();
            this.lbl_openMapStatus = new System.Windows.Forms.Label();
            this.btn_openImg = new System.Windows.Forms.Button();
            this.pb_Simulation = new System.Windows.Forms.PictureBox();
            this.pb_launch = new System.Windows.Forms.PictureBox();
            this.pcb_start = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_ccount = new System.Windows.Forms.Label();
            this.gb_ccount = new System.Windows.Forms.GroupBox();
            this.rbtn_p5 = new System.Windows.Forms.RadioButton();
            this.rbtn_p8 = new System.Windows.Forms.RadioButton();
            this.rbtn_p3 = new System.Windows.Forms.RadioButton();
            this.rbtn_p7 = new System.Windows.Forms.RadioButton();
            this.rbtn_p6 = new System.Windows.Forms.RadioButton();
            this.rbtn_p4 = new System.Windows.Forms.RadioButton();
            this.gb_countries = new System.Windows.Forms.GroupBox();
            this.gb_generate = new System.Windows.Forms.GroupBox();
            this.rbtn_dryland = new System.Windows.Forms.RadioButton();
            this.rbtn_Continents = new System.Windows.Forms.RadioButton();
            this.rbtn_lake = new System.Windows.Forms.RadioButton();
            this.rbtn_waterworld = new System.Windows.Forms.RadioButton();
            this.rbtn_continent = new System.Windows.Forms.RadioButton();
            this.gb_map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Simulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_launch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_start)).BeginInit();
            this.gb_ccount.SuspendLayout();
            this.gb_countries.SuspendLayout();
            this.gb_generate.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.ForeColor = System.Drawing.Color.Red;
            this.lbl_message.Location = new System.Drawing.Point(1363, 198);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 13);
            this.lbl_message.TabIndex = 4;
            // 
            // lbl_mset
            // 
            this.lbl_mset.AutoSize = true;
            this.lbl_mset.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mset.Location = new System.Drawing.Point(240, 119);
            this.lbl_mset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mset.Name = "lbl_mset";
            this.lbl_mset.Size = new System.Drawing.Size(145, 66);
            this.lbl_mset.TabIndex = 6;
            this.lbl_mset.Text = "Map";
            this.lbl_mset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cset
            // 
            this.lbl_cset.AutoSize = true;
            this.lbl_cset.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cset.Location = new System.Drawing.Point(1059, 119);
            this.lbl_cset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cset.Name = "lbl_cset";
            this.lbl_cset.Size = new System.Drawing.Size(379, 66);
            this.lbl_cset.TabIndex = 7;
            this.lbl_cset.Text = "Countries";
            this.lbl_cset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_set
            // 
            this.lbl_set.AutoSize = true;
            this.lbl_set.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_set.Location = new System.Drawing.Point(591, 9);
            this.lbl_set.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_set.Name = "lbl_set";
            this.lbl_set.Size = new System.Drawing.Size(340, 66);
            this.lbl_set.TabIndex = 8;
            this.lbl_set.Text = "Settings";
            this.lbl_set.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtn_loadMap
            // 
            this.rbtn_loadMap.AutoSize = true;
            this.rbtn_loadMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_loadMap.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_loadMap.Location = new System.Drawing.Point(171, 214);
            this.rbtn_loadMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtn_loadMap.Name = "rbtn_loadMap";
            this.rbtn_loadMap.Size = new System.Drawing.Size(70, 24);
            this.rbtn_loadMap.TabIndex = 9;
            this.rbtn_loadMap.TabStop = true;
            this.rbtn_loadMap.Text = "Load";
            this.rbtn_loadMap.UseVisualStyleBackColor = true;
            // 
            // rbtn_generateMap
            // 
            this.rbtn_generateMap.AutoSize = true;
            this.rbtn_generateMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_generateMap.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_generateMap.Location = new System.Drawing.Point(314, 214);
            this.rbtn_generateMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtn_generateMap.Name = "rbtn_generateMap";
            this.rbtn_generateMap.Size = new System.Drawing.Size(114, 24);
            this.rbtn_generateMap.TabIndex = 10;
            this.rbtn_generateMap.TabStop = true;
            this.rbtn_generateMap.Text = "Generate";
            this.rbtn_generateMap.UseVisualStyleBackColor = true;
            // 
            // cb_agressive
            // 
            this.cb_agressive.AutoSize = true;
            this.cb_agressive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_agressive.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_agressive.Location = new System.Drawing.Point(51, 18);
            this.cb_agressive.Name = "cb_agressive";
            this.cb_agressive.Size = new System.Drawing.Size(124, 24);
            this.cb_agressive.TabIndex = 11;
            this.cb_agressive.Text = "Agressive";
            this.cb_agressive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_agressive.UseVisualStyleBackColor = true;
            // 
            // cb_peacekeeper
            // 
            this.cb_peacekeeper.AutoSize = true;
            this.cb_peacekeeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_peacekeeper.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_peacekeeper.Location = new System.Drawing.Point(51, 50);
            this.cb_peacekeeper.Name = "cb_peacekeeper";
            this.cb_peacekeeper.Size = new System.Drawing.Size(146, 24);
            this.cb_peacekeeper.TabIndex = 12;
            this.cb_peacekeeper.Text = "Peacekeeper";
            this.cb_peacekeeper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_peacekeeper.UseVisualStyleBackColor = true;
            // 
            // cb_green_movement
            // 
            this.cb_green_movement.AutoSize = true;
            this.cb_green_movement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_green_movement.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_green_movement.Location = new System.Drawing.Point(51, 78);
            this.cb_green_movement.Name = "cb_green_movement";
            this.cb_green_movement.Size = new System.Drawing.Size(179, 24);
            this.cb_green_movement.TabIndex = 13;
            this.cb_green_movement.Text = "Green Movement";
            this.cb_green_movement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_green_movement.UseVisualStyleBackColor = true;
            // 
            // cb_hard_terrain
            // 
            this.cb_hard_terrain.AutoSize = true;
            this.cb_hard_terrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_hard_terrain.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_hard_terrain.Location = new System.Drawing.Point(51, 108);
            this.cb_hard_terrain.Name = "cb_hard_terrain";
            this.cb_hard_terrain.Size = new System.Drawing.Size(157, 24);
            this.cb_hard_terrain.TabIndex = 14;
            this.cb_hard_terrain.Text = "Hard Terrain";
            this.cb_hard_terrain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_hard_terrain.UseVisualStyleBackColor = true;
            // 
            // gb_map
            // 
            this.gb_map.Controls.Add(this.lbl_openMapStatus);
            this.gb_map.Controls.Add(this.btn_openImg);
            this.gb_map.Controls.Add(this.pb_Simulation);
            this.gb_map.Location = new System.Drawing.Point(171, 244);
            this.gb_map.Name = "gb_map";
            this.gb_map.Size = new System.Drawing.Size(298, 236);
            this.gb_map.TabIndex = 15;
            this.gb_map.TabStop = false;
            this.gb_map.Text = "Load Map";
            // 
            // lbl_openMapStatus
            // 
            this.lbl_openMapStatus.AutoSize = true;
            this.lbl_openMapStatus.Location = new System.Drawing.Point(143, 30);
            this.lbl_openMapStatus.Name = "lbl_openMapStatus";
            this.lbl_openMapStatus.Size = new System.Drawing.Size(0, 13);
            this.lbl_openMapStatus.TabIndex = 1;
            // 
            // btn_openImg
            // 
            this.btn_openImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openImg.ForeColor = System.Drawing.Color.White;
            this.btn_openImg.Location = new System.Drawing.Point(27, 21);
            this.btn_openImg.Name = "btn_openImg";
            this.btn_openImg.Size = new System.Drawing.Size(75, 23);
            this.btn_openImg.TabIndex = 0;
            this.btn_openImg.Text = "Open";
            this.btn_openImg.UseVisualStyleBackColor = true;
            this.btn_openImg.Click += new System.EventHandler(this.btn_openImg_Click);
            // 
            // pb_Simulation
            // 
            this.pb_Simulation.Location = new System.Drawing.Point(15, 50);
            this.pb_Simulation.Name = "pb_Simulation";
            this.pb_Simulation.Size = new System.Drawing.Size(267, 172);
            this.pb_Simulation.TabIndex = 17;
            this.pb_Simulation.TabStop = false;
            // 
            // pb_launch
            // 
            this.pb_launch.BackColor = System.Drawing.Color.Transparent;
            this.pb_launch.Image = global::Pocket_Planet.Properties.Resources.button_gif_white;
            this.pb_launch.Location = new System.Drawing.Point(680, 383);
            this.pb_launch.Name = "pb_launch";
            this.pb_launch.Size = new System.Drawing.Size(188, 199);
            this.pb_launch.TabIndex = 16;
            this.pb_launch.TabStop = false;
            this.pb_launch.Visible = false;
            this.pb_launch.Click += new System.EventHandler(this.pb_launch_Click);
            // 
            // pcb_start
            // 
            this.pcb_start.BackColor = System.Drawing.Color.Transparent;
            this.pcb_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcb_start.Image = global::Pocket_Planet.Properties.Resources.PPstart;
            this.pcb_start.Location = new System.Drawing.Point(541, 417);
            this.pcb_start.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pcb_start.Name = "pcb_start";
            this.pcb_start.Size = new System.Drawing.Size(637, 213);
            this.pcb_start.TabIndex = 5;
            this.pcb_start.TabStop = false;
            this.pcb_start.Click += new System.EventHandler(this.pcb_start_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files | *.png;*.jpg;*.bmp";
            this.openFileDialog1.Title = "Open Image";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lbl_ccount
            // 
            this.lbl_ccount.AutoSize = true;
            this.lbl_ccount.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ccount.Location = new System.Drawing.Point(563, 142);
            this.lbl_ccount.Name = "lbl_ccount";
            this.lbl_ccount.Size = new System.Drawing.Size(435, 39);
            this.lbl_ccount.TabIndex = 18;
            this.lbl_ccount.Text = "Number of countries";
            // 
            // gb_ccount
            // 
            this.gb_ccount.Controls.Add(this.rbtn_p5);
            this.gb_ccount.Controls.Add(this.rbtn_p8);
            this.gb_ccount.Controls.Add(this.rbtn_p3);
            this.gb_ccount.Controls.Add(this.rbtn_p7);
            this.gb_ccount.Controls.Add(this.rbtn_p6);
            this.gb_ccount.Controls.Add(this.rbtn_p4);
            this.gb_ccount.Location = new System.Drawing.Point(623, 244);
            this.gb_ccount.Name = "gb_ccount";
            this.gb_ccount.Size = new System.Drawing.Size(340, 102);
            this.gb_ccount.TabIndex = 19;
            this.gb_ccount.TabStop = false;
            // 
            // rbtn_p5
            // 
            this.rbtn_p5.AutoSize = true;
            this.rbtn_p5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_p5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbtn_p5.Location = new System.Drawing.Point(42, 74);
            this.rbtn_p5.Name = "rbtn_p5";
            this.rbtn_p5.Size = new System.Drawing.Size(96, 17);
            this.rbtn_p5.TabIndex = 5;
            this.rbtn_p5.TabStop = true;
            this.rbtn_p5.Text = "Scattered";
            this.rbtn_p5.UseVisualStyleBackColor = true;
            this.rbtn_p5.CheckedChanged += new System.EventHandler(this.rbtn_p5_CheckedChanged);
            // 
            // rbtn_p8
            // 
            this.rbtn_p8.AutoSize = true;
            this.rbtn_p8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_p8.ForeColor = System.Drawing.Color.Red;
            this.rbtn_p8.Location = new System.Drawing.Point(188, 74);
            this.rbtn_p8.Name = "rbtn_p8";
            this.rbtn_p8.Size = new System.Drawing.Size(72, 17);
            this.rbtn_p8.TabIndex = 4;
            this.rbtn_p8.TabStop = true;
            this.rbtn_p8.Text = "RUSSIA";
            this.rbtn_p8.UseVisualStyleBackColor = true;
            this.rbtn_p8.CheckedChanged += new System.EventHandler(this.rbtn_p8_CheckedChanged);
            // 
            // rbtn_p3
            // 
            this.rbtn_p3.AutoSize = true;
            this.rbtn_p3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_p3.ForeColor = System.Drawing.Color.Lime;
            this.rbtn_p3.Location = new System.Drawing.Point(42, 18);
            this.rbtn_p3.Name = "rbtn_p3";
            this.rbtn_p3.Size = new System.Drawing.Size(56, 17);
            this.rbtn_p3.TabIndex = 3;
            this.rbtn_p3.TabStop = true;
            this.rbtn_p3.Text = "Mere";
            this.rbtn_p3.UseVisualStyleBackColor = true;
            this.rbtn_p3.CheckedChanged += new System.EventHandler(this.rbtn_p3_CheckedChanged);
            // 
            // rbtn_p7
            // 
            this.rbtn_p7.AutoSize = true;
            this.rbtn_p7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_p7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbtn_p7.Location = new System.Drawing.Point(188, 46);
            this.rbtn_p7.Name = "rbtn_p7";
            this.rbtn_p7.Size = new System.Drawing.Size(80, 17);
            this.rbtn_p7.TabIndex = 2;
            this.rbtn_p7.TabStop = true;
            this.rbtn_p7.Text = "Crowded";
            this.rbtn_p7.UseVisualStyleBackColor = true;
            this.rbtn_p7.CheckedChanged += new System.EventHandler(this.rbtn_p7_CheckedChanged);
            // 
            // rbtn_p6
            // 
            this.rbtn_p6.AutoSize = true;
            this.rbtn_p6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_p6.ForeColor = System.Drawing.Color.Yellow;
            this.rbtn_p6.Location = new System.Drawing.Point(188, 18);
            this.rbtn_p6.Name = "rbtn_p6";
            this.rbtn_p6.Size = new System.Drawing.Size(104, 17);
            this.rbtn_p6.TabIndex = 1;
            this.rbtn_p6.TabStop = true;
            this.rbtn_p6.Text = "Infrequent";
            this.rbtn_p6.UseVisualStyleBackColor = true;
            this.rbtn_p6.CheckedChanged += new System.EventHandler(this.rbtn_p6_CheckedChanged);
            // 
            // rbtn_p4
            // 
            this.rbtn_p4.AutoSize = true;
            this.rbtn_p4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_p4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rbtn_p4.Location = new System.Drawing.Point(42, 46);
            this.rbtn_p4.Name = "rbtn_p4";
            this.rbtn_p4.Size = new System.Drawing.Size(72, 17);
            this.rbtn_p4.TabIndex = 0;
            this.rbtn_p4.TabStop = true;
            this.rbtn_p4.Text = "Sparse";
            this.rbtn_p4.UseVisualStyleBackColor = true;
            this.rbtn_p4.CheckedChanged += new System.EventHandler(this.rbtn_p4_CheckedChanged);
            // 
            // gb_countries
            // 
            this.gb_countries.Controls.Add(this.cb_agressive);
            this.gb_countries.Controls.Add(this.cb_peacekeeper);
            this.gb_countries.Controls.Add(this.cb_green_movement);
            this.gb_countries.Controls.Add(this.cb_hard_terrain);
            this.gb_countries.Location = new System.Drawing.Point(1099, 244);
            this.gb_countries.Name = "gb_countries";
            this.gb_countries.Size = new System.Drawing.Size(264, 153);
            this.gb_countries.TabIndex = 20;
            this.gb_countries.TabStop = false;
            // 
            // gb_generate
            // 
            this.gb_generate.Controls.Add(this.rbtn_dryland);
            this.gb_generate.Controls.Add(this.rbtn_Continents);
            this.gb_generate.Controls.Add(this.rbtn_lake);
            this.gb_generate.Controls.Add(this.rbtn_waterworld);
            this.gb_generate.Controls.Add(this.rbtn_continent);
            this.gb_generate.Location = new System.Drawing.Point(171, 244);
            this.gb_generate.Name = "gb_generate";
            this.gb_generate.Size = new System.Drawing.Size(298, 236);
            this.gb_generate.TabIndex = 18;
            this.gb_generate.TabStop = false;
            this.gb_generate.Text = "Load Map";
            // 
            // rbtn_dryland
            // 
            this.rbtn_dryland.AutoSize = true;
            this.rbtn_dryland.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_dryland.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_dryland.Location = new System.Drawing.Point(48, 189);
            this.rbtn_dryland.Name = "rbtn_dryland";
            this.rbtn_dryland.Size = new System.Drawing.Size(95, 21);
            this.rbtn_dryland.TabIndex = 4;
            this.rbtn_dryland.TabStop = true;
            this.rbtn_dryland.Text = "Dryland";
            this.rbtn_dryland.UseVisualStyleBackColor = true;
            // 
            // rbtn_Continents
            // 
            this.rbtn_Continents.AutoSize = true;
            this.rbtn_Continents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_Continents.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Continents.Location = new System.Drawing.Point(48, 148);
            this.rbtn_Continents.Name = "rbtn_Continents";
            this.rbtn_Continents.Size = new System.Drawing.Size(125, 21);
            this.rbtn_Continents.TabIndex = 3;
            this.rbtn_Continents.TabStop = true;
            this.rbtn_Continents.Text = "Continents";
            this.rbtn_Continents.UseVisualStyleBackColor = true;
            // 
            // rbtn_lake
            // 
            this.rbtn_lake.AutoSize = true;
            this.rbtn_lake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_lake.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_lake.Location = new System.Drawing.Point(48, 108);
            this.rbtn_lake.Name = "rbtn_lake";
            this.rbtn_lake.Size = new System.Drawing.Size(65, 21);
            this.rbtn_lake.TabIndex = 2;
            this.rbtn_lake.TabStop = true;
            this.rbtn_lake.Text = "Lake";
            this.rbtn_lake.UseVisualStyleBackColor = true;
            // 
            // rbtn_waterworld
            // 
            this.rbtn_waterworld.AutoSize = true;
            this.rbtn_waterworld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_waterworld.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_waterworld.Location = new System.Drawing.Point(48, 70);
            this.rbtn_waterworld.Name = "rbtn_waterworld";
            this.rbtn_waterworld.Size = new System.Drawing.Size(125, 21);
            this.rbtn_waterworld.TabIndex = 1;
            this.rbtn_waterworld.TabStop = true;
            this.rbtn_waterworld.Text = "Waterworld";
            this.rbtn_waterworld.UseVisualStyleBackColor = true;
            // 
            // rbtn_continent
            // 
            this.rbtn_continent.AutoSize = true;
            this.rbtn_continent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_continent.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_continent.Location = new System.Drawing.Point(48, 30);
            this.rbtn_continent.Name = "rbtn_continent";
            this.rbtn_continent.Size = new System.Drawing.Size(115, 21);
            this.rbtn_continent.TabIndex = 0;
            this.rbtn_continent.TabStop = true;
            this.rbtn_continent.Text = "Continent";
            this.rbtn_continent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1511, 658);
            this.Controls.Add(this.gb_generate);
            this.Controls.Add(this.gb_countries);
            this.Controls.Add(this.gb_ccount);
            this.Controls.Add(this.lbl_ccount);
            this.Controls.Add(this.pb_launch);
            this.Controls.Add(this.gb_map);
            this.Controls.Add(this.rbtn_generateMap);
            this.Controls.Add(this.rbtn_loadMap);
            this.Controls.Add(this.lbl_set);
            this.Controls.Add(this.lbl_cset);
            this.Controls.Add(this.lbl_mset);
            this.Controls.Add(this.pcb_start);
            this.Controls.Add(this.lbl_message);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pocket Planet";
            this.gb_map.ResumeLayout(false);
            this.gb_map.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Simulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_launch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_start)).EndInit();
            this.gb_ccount.ResumeLayout(false);
            this.gb_ccount.PerformLayout();
            this.gb_countries.ResumeLayout(false);
            this.gb_countries.PerformLayout();
            this.gb_generate.ResumeLayout(false);
            this.gb_generate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.PictureBox pcb_start;
        private System.Windows.Forms.Label lbl_mset;
        private System.Windows.Forms.Label lbl_cset;
        private System.Windows.Forms.Label lbl_set;
        private System.Windows.Forms.RadioButton rbtn_loadMap;
        private System.Windows.Forms.RadioButton rbtn_generateMap;
        private System.Windows.Forms.CheckBox cb_agressive;
        private System.Windows.Forms.CheckBox cb_peacekeeper;
        private System.Windows.Forms.CheckBox cb_green_movement;
        private System.Windows.Forms.CheckBox cb_hard_terrain;
        private System.Windows.Forms.GroupBox gb_map;
        private System.Windows.Forms.Button btn_openImg;
        private System.Windows.Forms.Label lbl_openMapStatus;
        private System.Windows.Forms.PictureBox pb_launch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pb_Simulation;
        private System.Windows.Forms.Label lbl_ccount;
        private System.Windows.Forms.GroupBox gb_ccount;
        private System.Windows.Forms.RadioButton rbtn_p3;
        private System.Windows.Forms.RadioButton rbtn_p7;
        private System.Windows.Forms.RadioButton rbtn_p6;
        private System.Windows.Forms.RadioButton rbtn_p4;
        private System.Windows.Forms.RadioButton rbtn_p5;
        private System.Windows.Forms.RadioButton rbtn_p8;
        private System.Windows.Forms.GroupBox gb_countries;
        private System.Windows.Forms.GroupBox gb_generate;
        private System.Windows.Forms.RadioButton rbtn_Continents;
        private System.Windows.Forms.RadioButton rbtn_lake;
        private System.Windows.Forms.RadioButton rbtn_waterworld;
        private System.Windows.Forms.RadioButton rbtn_continent;
        private System.Windows.Forms.RadioButton rbtn_dryland;
    }
}

