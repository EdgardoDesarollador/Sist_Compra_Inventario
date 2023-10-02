namespace Categoria
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            panYRelkToolStripMenuItem = new ToolStripMenuItem();
            pastasToolStripMenuItem = new ToolStripMenuItem();
            cerealesToolStripMenuItem = new ToolStripMenuItem();
            arrozToolStripMenuItem = new ToolStripMenuItem();
            maizToolStripMenuItem = new ToolStripMenuItem();
            frijolesToolStripMenuItem = new ToolStripMenuItem();
            trigoToolStripMenuItem = new ToolStripMenuItem();
            golosinasToolStripMenuItem = new ToolStripMenuItem();
            chocolatesToolStripMenuItem = new ToolStripMenuItem();
            heladosToolStripMenuItem = new ToolStripMenuItem();
            churrosToolStripMenuItem = new ToolStripMenuItem();
            azucarToolStripMenuItem = new ToolStripMenuItem();
            mielToolStripMenuItem = new ToolStripMenuItem();
            lacteosToolStripMenuItem = new ToolStripMenuItem();
            carnesToolStripMenuItem = new ToolStripMenuItem();
            blancasToolStripMenuItem = new ToolStripMenuItem();
            rojasToolStripMenuItem = new ToolStripMenuItem();
            aceitesToolStripMenuItem = new ToolStripMenuItem();
            consomesToolStripMenuItem = new ToolStripMenuItem();
            zopasToolStripMenuItem = new ToolStripMenuItem();
            verdurasToolStripMenuItem = new ToolStripMenuItem();
            bebidasToolStripMenuItem = new ToolStripMenuItem();
            buscar = new TextBox();
            button1 = new Button();
            agregar = new Button();
            eliminar = new Button();
            editar = new Button();
            regresar = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { panYRelkToolStripMenuItem, pastasToolStripMenuItem, cerealesToolStripMenuItem, golosinasToolStripMenuItem, azucarToolStripMenuItem, lacteosToolStripMenuItem, carnesToolStripMenuItem, aceitesToolStripMenuItem, verdurasToolStripMenuItem, bebidasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(12, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(116, 358);
            menuStrip1.TabIndex = 0;
            menuStrip1.TabStop = true;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // panYRelkToolStripMenuItem
            // 
            panYRelkToolStripMenuItem.Image = Properties.Resources.pan;
            panYRelkToolStripMenuItem.Name = "panYRelkToolStripMenuItem";
            panYRelkToolStripMenuItem.Size = new Size(91, 23);
            panYRelkToolStripMenuItem.Text = "Panaderia";
            // 
            // pastasToolStripMenuItem
            // 
            pastasToolStripMenuItem.Image = Properties.Resources.pas;
            pastasToolStripMenuItem.Name = "pastasToolStripMenuItem";
            pastasToolStripMenuItem.Size = new Size(91, 23);
            pastasToolStripMenuItem.Text = "Pastas";
            // 
            // cerealesToolStripMenuItem
            // 
            cerealesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arrozToolStripMenuItem, maizToolStripMenuItem, frijolesToolStripMenuItem, trigoToolStripMenuItem });
            cerealesToolStripMenuItem.Image = Properties.Resources.cereal;
            cerealesToolStripMenuItem.Name = "cerealesToolStripMenuItem";
            cerealesToolStripMenuItem.Size = new Size(91, 23);
            cerealesToolStripMenuItem.Text = "Cereales";
            // 
            // arrozToolStripMenuItem
            // 
            arrozToolStripMenuItem.Name = "arrozToolStripMenuItem";
            arrozToolStripMenuItem.Size = new Size(128, 24);
            arrozToolStripMenuItem.Text = "Arroz";
            // 
            // maizToolStripMenuItem
            // 
            maizToolStripMenuItem.Name = "maizToolStripMenuItem";
            maizToolStripMenuItem.Size = new Size(128, 24);
            maizToolStripMenuItem.Text = "Maiz";
            // 
            // frijolesToolStripMenuItem
            // 
            frijolesToolStripMenuItem.Name = "frijolesToolStripMenuItem";
            frijolesToolStripMenuItem.Size = new Size(128, 24);
            frijolesToolStripMenuItem.Text = "Frijoles";
            // 
            // trigoToolStripMenuItem
            // 
            trigoToolStripMenuItem.Name = "trigoToolStripMenuItem";
            trigoToolStripMenuItem.Size = new Size(128, 24);
            trigoToolStripMenuItem.Text = "Trigo";
            // 
            // golosinasToolStripMenuItem
            // 
            golosinasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chocolatesToolStripMenuItem, heladosToolStripMenuItem, churrosToolStripMenuItem });
            golosinasToolStripMenuItem.Image = Properties.Resources.golosi;
            golosinasToolStripMenuItem.Name = "golosinasToolStripMenuItem";
            golosinasToolStripMenuItem.Size = new Size(91, 23);
            golosinasToolStripMenuItem.Text = "Golosinas";
            // 
            // chocolatesToolStripMenuItem
            // 
            chocolatesToolStripMenuItem.Name = "chocolatesToolStripMenuItem";
            chocolatesToolStripMenuItem.Size = new Size(152, 24);
            chocolatesToolStripMenuItem.Text = "Chocolates";
            // 
            // heladosToolStripMenuItem
            // 
            heladosToolStripMenuItem.Name = "heladosToolStripMenuItem";
            heladosToolStripMenuItem.Size = new Size(152, 24);
            heladosToolStripMenuItem.Text = "Helados";
            // 
            // churrosToolStripMenuItem
            // 
            churrosToolStripMenuItem.Name = "churrosToolStripMenuItem";
            churrosToolStripMenuItem.Size = new Size(152, 24);
            churrosToolStripMenuItem.Text = "Churros";
            // 
            // azucarToolStripMenuItem
            // 
            azucarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mielToolStripMenuItem });
            azucarToolStripMenuItem.Image = Properties.Resources.azucar;
            azucarToolStripMenuItem.Name = "azucarToolStripMenuItem";
            azucarToolStripMenuItem.Size = new Size(91, 23);
            azucarToolStripMenuItem.Text = "Azucar";
            // 
            // mielToolStripMenuItem
            // 
            mielToolStripMenuItem.Name = "mielToolStripMenuItem";
            mielToolStripMenuItem.Size = new Size(110, 24);
            mielToolStripMenuItem.Text = "Miel";
            // 
            // lacteosToolStripMenuItem
            // 
            lacteosToolStripMenuItem.Image = Properties.Resources.lacteo;
            lacteosToolStripMenuItem.Name = "lacteosToolStripMenuItem";
            lacteosToolStripMenuItem.Size = new Size(91, 23);
            lacteosToolStripMenuItem.Text = "Lacteos";
            // 
            // carnesToolStripMenuItem
            // 
            carnesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { blancasToolStripMenuItem, rojasToolStripMenuItem });
            carnesToolStripMenuItem.Image = Properties.Resources.carnes;
            carnesToolStripMenuItem.Name = "carnesToolStripMenuItem";
            carnesToolStripMenuItem.Size = new Size(91, 23);
            carnesToolStripMenuItem.Text = "Carnes";
            // 
            // blancasToolStripMenuItem
            // 
            blancasToolStripMenuItem.Name = "blancasToolStripMenuItem";
            blancasToolStripMenuItem.Size = new Size(131, 24);
            blancasToolStripMenuItem.Text = "Blancas";
            // 
            // rojasToolStripMenuItem
            // 
            rojasToolStripMenuItem.Name = "rojasToolStripMenuItem";
            rojasToolStripMenuItem.Size = new Size(131, 24);
            rojasToolStripMenuItem.Text = "Rojas";
            // 
            // aceitesToolStripMenuItem
            // 
            aceitesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consomesToolStripMenuItem, zopasToolStripMenuItem });
            aceitesToolStripMenuItem.Image = Properties.Resources.aceite;
            aceitesToolStripMenuItem.Name = "aceitesToolStripMenuItem";
            aceitesToolStripMenuItem.Size = new Size(91, 23);
            aceitesToolStripMenuItem.Text = "Aceites";
            // 
            // consomesToolStripMenuItem
            // 
            consomesToolStripMenuItem.Name = "consomesToolStripMenuItem";
            consomesToolStripMenuItem.Size = new Size(147, 24);
            consomesToolStripMenuItem.Text = "Consomes";
            // 
            // zopasToolStripMenuItem
            // 
            zopasToolStripMenuItem.Name = "zopasToolStripMenuItem";
            zopasToolStripMenuItem.Size = new Size(147, 24);
            zopasToolStripMenuItem.Text = "Zopas";
            // 
            // verdurasToolStripMenuItem
            // 
            verdurasToolStripMenuItem.Image = Properties.Resources.verdura1;
            verdurasToolStripMenuItem.Name = "verdurasToolStripMenuItem";
            verdurasToolStripMenuItem.Size = new Size(91, 23);
            verdurasToolStripMenuItem.Text = "Verduras";
            // 
            // bebidasToolStripMenuItem
            // 
            bebidasToolStripMenuItem.Image = Properties.Resources.bebida;
            bebidasToolStripMenuItem.Name = "bebidasToolStripMenuItem";
            bebidasToolStripMenuItem.Size = new Size(91, 23);
            bebidasToolStripMenuItem.Text = "Bebidas";
            // 
            // buscar
            // 
            buscar.Location = new Point(141, 12);
            buscar.Name = "buscar";
            buscar.Size = new Size(159, 35);
            buscar.TabIndex = 1;
            buscar.TextChanged += textBox1_TextChanged_1;
            // 
            // button1
            // 
            button1.Location = new Point(306, 13);
            button1.Name = "button1";
            button1.Size = new Size(97, 34);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // agregar
            // 
            agregar.Location = new Point(424, 13);
            agregar.Name = "agregar";
            agregar.Size = new Size(110, 35);
            agregar.TabIndex = 3;
            agregar.Text = "Agregar";
            agregar.UseVisualStyleBackColor = true;
            // 
            // eliminar
            // 
            eliminar.Location = new Point(637, 13);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(113, 36);
            eliminar.TabIndex = 4;
            eliminar.Text = "Eliminar";
            eliminar.UseVisualStyleBackColor = true;
            // 
            // editar
            // 
            editar.Location = new Point(540, 14);
            editar.Name = "editar";
            editar.Size = new Size(91, 35);
            editar.TabIndex = 5;
            editar.Text = "Editar";
            editar.UseVisualStyleBackColor = true;
            // 
            // regresar
            // 
            regresar.Location = new Point(756, 12);
            regresar.Name = "regresar";
            regresar.Size = new Size(75, 37);
            regresar.TabIndex = 6;
            regresar.Text = "Back";
            regresar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.logo;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(836, 358);
            Controls.Add(regresar);
            Controls.Add(editar);
            Controls.Add(eliminar);
            Controls.Add(agregar);
            Controls.Add(button1);
            Controls.Add(buscar);
            Controls.Add(menuStrip1);
            Cursor = Cursors.Default;
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Categoria";
            TransparencyKey = Color.FromArgb(64, 64, 64);
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem panYRelkToolStripMenuItem;
        private ToolStripMenuItem pastasToolStripMenuItem;
        private ToolStripMenuItem cerealesToolStripMenuItem;
        private ToolStripMenuItem arrozToolStripMenuItem;
        private ToolStripMenuItem maizToolStripMenuItem;
        private ToolStripMenuItem frijolesToolStripMenuItem;
        private ToolStripMenuItem trigoToolStripMenuItem;
        private ToolStripMenuItem golosinasToolStripMenuItem;
        private ToolStripMenuItem chocolatesToolStripMenuItem;
        private ToolStripMenuItem heladosToolStripMenuItem;
        private ToolStripMenuItem churrosToolStripMenuItem;
        private ToolStripMenuItem azucarToolStripMenuItem;
        private ToolStripMenuItem mielToolStripMenuItem;
        private ToolStripMenuItem lacteosToolStripMenuItem;
        private ToolStripMenuItem carnesToolStripMenuItem;
        private ToolStripMenuItem blancasToolStripMenuItem;
        private ToolStripMenuItem rojasToolStripMenuItem;
        private ToolStripMenuItem aceitesToolStripMenuItem;
        private ToolStripMenuItem consomesToolStripMenuItem;
        private ToolStripMenuItem zopasToolStripMenuItem;
        private ToolStripMenuItem verdurasToolStripMenuItem;
        private ToolStripMenuItem bebidasToolStripMenuItem;
        private TextBox buscar;
        private Button button1;
        private Button agregar;
        private Button eliminar;
        private Button editar;
        private Button regresar;
    }
}