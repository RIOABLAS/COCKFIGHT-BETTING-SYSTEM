using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Cockfight_Betting_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Cockfight Betting System";
            this.Size = new System.Drawing.Size(1200, 1000);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(25, 25, 25);
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // Header Panel
            Panel headerPanel = new Panel();
            headerPanel.BackColor = Color.FromArgb(40, 40, 40);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 60;
            headerPanel.Padding = new Padding(15);
            headerPanel.BorderStyle = BorderStyle.FixedSingle;

            // Header Rooster Icon (GIF)
            PictureBox headerIconPictureBox = new PictureBox();
            headerIconPictureBox.BackColor = Color.Transparent;
            headerIconPictureBox.Size = new Size(40, 40);
            headerIconPictureBox.Location = new Point(15, 10);
            headerIconPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            headerIconPictureBox.BorderStyle = BorderStyle.None;
            
            try
            {
                string headerPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "header_icon.gif");
                if (File.Exists(headerPath))
                    headerIconPictureBox.Image = Image.FromFile(headerPath);
                else if (File.Exists("header_icon.gif"))
                    headerIconPictureBox.Image = Image.FromFile("header_icon.gif");
                else if (File.Exists("rooster_icon.gif"))
                    headerIconPictureBox.Image = Image.FromFile("rooster_icon.gif");
            }
            catch { }
            
            headerPanel.Controls.Add(headerIconPictureBox);

            Label titleLabel = new Label();
            titleLabel.Text = "🔴 LIVE - COCKFIGHT BETTING";
            titleLabel.ForeColor = Color.White;
            titleLabel.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(65, 15);
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            headerPanel.Controls.Add(titleLabel);
            this.Controls.Add(headerPanel);

            // Main content panel
            Panel contentPanel = new Panel();
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.BackColor = Color.FromArgb(25, 25, 25);
            contentPanel.Padding = new Padding(12);

            // Arena Image Panel - Large and prominent
            Panel arenaPanel = new Panel();
            arenaPanel.BackColor = Color.FromArgb(50, 50, 50);
            arenaPanel.BorderStyle = BorderStyle.FixedSingle;
            arenaPanel.Dock = DockStyle.Top;
            arenaPanel.Height = 350;
            arenaPanel.Margin = new Padding(0, 0, 0, 15);

            // Arena Background Image
            PictureBox arenaPictureBox = new PictureBox();
            arenaPictureBox.BackColor = Color.FromArgb(50, 50, 50);
            arenaPictureBox.Dock = DockStyle.Fill;
            arenaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            arenaPictureBox.BorderStyle = BorderStyle.None;
            
            try
            {
                string arenaPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "arena.gif");
                if (File.Exists(arenaPath))
                    arenaPictureBox.Image = Image.FromFile(arenaPath);
                else if (File.Exists("arena.gif"))
                    arenaPictureBox.Image = Image.FromFile("arena.gif");
                else if (File.Exists("arena.png"))
                    arenaPictureBox.Image = Image.FromFile("arena.png");
            }
            catch { }
            
            arenaPanel.Controls.Add(arenaPictureBox);

            // ========== LEFT ROOSTER (MERON) ==========
            PictureBox leftRoosterPictureBox = new PictureBox();
            leftRoosterPictureBox.BackColor = Color.Transparent;
            leftRoosterPictureBox.Size = new Size(180, 180);
            leftRoosterPictureBox.Location = new Point(80, 85);
            leftRoosterPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            leftRoosterPictureBox.BorderStyle = BorderStyle.None;
            leftRoosterPictureBox.Visible = true;
            
            try
            {
                string leftPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "left_rooster.gif");
                if (File.Exists(leftPath))
                {
                    leftRoosterPictureBox.Image = Image.FromFile(leftPath);
                    leftRoosterPictureBox.BringToFront();
                }
                else if (File.Exists("left_rooster.gif"))
                {
                    leftRoosterPictureBox.Image = Image.FromFile("left_rooster.gif");
                    leftRoosterPictureBox.BringToFront();
                }
                else if (File.Exists("rooster_left.gif"))
                {
                    leftRoosterPictureBox.Image = Image.FromFile("rooster_left.gif");
                    leftRoosterPictureBox.BringToFront();
                }
                else if (File.Exists("meron_rooster.gif"))
                {
                    leftRoosterPictureBox.Image = Image.FromFile("meron_rooster.gif");
                    leftRoosterPictureBox.BringToFront();
                }
            }
            catch { }
            
            arenaPanel.Controls.Add(leftRoosterPictureBox);
            leftRoosterPictureBox.BringToFront();

            // ========== RIGHT ROOSTER (WALA) ==========
            PictureBox rightRoosterPictureBox = new PictureBox();
            rightRoosterPictureBox.BackColor = Color.Transparent;
            rightRoosterPictureBox.Size = new Size(180, 180);
            rightRoosterPictureBox.Location = new Point(940, 85);
            rightRoosterPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            rightRoosterPictureBox.BorderStyle = BorderStyle.None;
            rightRoosterPictureBox.Visible = true;
            
            try
            {
                string rightPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "right_rooster.gif");
                if (File.Exists(rightPath))
                {
                    rightRoosterPictureBox.Image = Image.FromFile(rightPath);
                    rightRoosterPictureBox.BringToFront();
                }
                else if (File.Exists("right_rooster.gif"))
                {
                    rightRoosterPictureBox.Image = Image.FromFile("right_rooster.gif");
                    rightRoosterPictureBox.BringToFront();
                }
                else if (File.Exists("rooster_right.gif"))
                {
                    rightRoosterPictureBox.Image = Image.FromFile("rooster_right.gif");
                    rightRoosterPictureBox.BringToFront();
                }
                else if (File.Exists("wala_rooster.gif"))
                {
                    rightRoosterPictureBox.Image = Image.FromFile("wala_rooster.gif");
                    rightRoosterPictureBox.BringToFront();
                }
            }
            catch { }
            
            arenaPanel.Controls.Add(rightRoosterPictureBox);
            rightRoosterPictureBox.BringToFront();
            // ========== END ROOSTER CODE ==========

            contentPanel.Controls.Add(arenaPanel);

            // Betting Panels Container
            Panel bettingContainerPanel = new Panel();
            bettingContainerPanel.Dock = DockStyle.Top;
            bettingContainerPanel.Height = 250;
            bettingContainerPanel.BackColor = Color.FromArgb(25, 25, 25);
            bettingContainerPanel.Padding = new Padding(10);

            // MERON Panel (Left, Red)
            Panel meronPanel = new Panel();
            meronPanel.BackColor = Color.FromArgb(150, 40, 40);
            meronPanel.BorderStyle = BorderStyle.FixedSingle;
            meronPanel.Size = new Size(350, 220);
            meronPanel.Location = new Point(10, 10);

            Label meronAmountLabel = new Label();
            meronAmountLabel.Text = "0";
            meronAmountLabel.ForeColor = Color.White;
            meronAmountLabel.Font = new Font("Segoe UI", 56, FontStyle.Bold);
            meronAmountLabel.TextAlign = ContentAlignment.MiddleCenter;
            meronAmountLabel.Size = new Size(350, 60);
            meronAmountLabel.Location = new Point(0, 15);
            meronPanel.Controls.Add(meronAmountLabel);

            Label meronLabelText = new Label();
            meronLabelText.Text = "MERON";
            meronLabelText.ForeColor = Color.FromArgb(255, 130, 130);
            meronLabelText.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            meronLabelText.TextAlign = ContentAlignment.MiddleCenter;
            meronLabelText.Size = new Size(350, 50);
            meronLabelText.Location = new Point(0, 75);
            meronPanel.Controls.Add(meronLabelText);

            Button meronBetButton = new Button();
            meronBetButton.Text = "BET";
            meronBetButton.BackColor = Color.FromArgb(255, 130, 130);
            meronBetButton.ForeColor = Color.Black;
            meronBetButton.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            meronBetButton.Size = new Size(350, 55);
            meronBetButton.Location = new Point(0, 165);
            meronBetButton.FlatStyle = FlatStyle.Flat;
            meronBetButton.FlatAppearance.BorderSize = 0;
            meronBetButton.Click += MeronBetButton_Click;
            meronPanel.Controls.Add(meronBetButton);

            bettingContainerPanel.Controls.Add(meronPanel);

            // WALA Panel (Middle, Blue)
            Panel walaPanel = new Panel();
            walaPanel.BackColor = Color.FromArgb(30, 70, 140);
            walaPanel.BorderStyle = BorderStyle.FixedSingle;
            walaPanel.Size = new Size(350, 220);
            walaPanel.Location = new Point(400, 10);

            Label walaAmountLabel = new Label();
            walaAmountLabel.Text = "1000.00";
            walaAmountLabel.ForeColor = Color.White;
            walaAmountLabel.Font = new Font("Segoe UI", 56, FontStyle.Bold);
            walaAmountLabel.TextAlign = ContentAlignment.MiddleCenter;
            walaAmountLabel.Size = new Size(350, 60);
            walaAmountLabel.Location = new Point(0, 15);
            walaPanel.Controls.Add(walaAmountLabel);

            Label walaLabelText = new Label();
            walaLabelText.Text = "WALA";
            walaLabelText.ForeColor = Color.FromArgb(135, 206, 250);
            walaLabelText.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            walaLabelText.TextAlign = ContentAlignment.MiddleCenter;
            walaLabelText.Size = new Size(350, 50);
            walaLabelText.Location = new Point(0, 75);
            walaPanel.Controls.Add(walaLabelText);

            Button walaBetButton = new Button();
            walaBetButton.Text = "BET";
            walaBetButton.BackColor = Color.FromArgb(100, 180, 255);
            walaBetButton.ForeColor = Color.Black;
            walaBetButton.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            walaBetButton.Size = new Size(350, 55);
            walaBetButton.Location = new Point(0, 165);
            walaBetButton.FlatStyle = FlatStyle.Flat;
            walaBetButton.FlatAppearance.BorderSize = 0;
            walaBetButton.Click += WalaBetButton_Click;
            walaPanel.Controls.Add(walaBetButton);

            bettingContainerPanel.Controls.Add(walaPanel);

            // DRAW Panel (Right, Green)
            Panel drawPanel = new Panel();
            drawPanel.BackColor = Color.FromArgb(40, 130, 40);
            drawPanel.BorderStyle = BorderStyle.FixedSingle;
            drawPanel.Size = new Size(350, 220);
            drawPanel.Location = new Point(790, 10);

            Label drawAmountLabel = new Label();
            drawAmountLabel.Text = "0";
            drawAmountLabel.ForeColor = Color.White;
            drawAmountLabel.Font = new Font("Segoe UI", 56, FontStyle.Bold);
            drawAmountLabel.TextAlign = ContentAlignment.MiddleCenter;
            drawAmountLabel.Size = new Size(350, 60);
            drawAmountLabel.Location = new Point(0, 15);
            drawPanel.Controls.Add(drawAmountLabel);

            Label drawLabelText = new Label();
            drawLabelText.Text = "DRAW";
            drawLabelText.ForeColor = Color.LimeGreen;
            drawLabelText.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            drawLabelText.TextAlign = ContentAlignment.MiddleCenter;
            drawLabelText.Size = new Size(350, 50);
            drawLabelText.Location = new Point(0, 75);
            drawPanel.Controls.Add(drawLabelText);

            Button drawBetButton = new Button();
            drawBetButton.Text = "BET";
            drawBetButton.BackColor = Color.LimeGreen;
            drawBetButton.ForeColor = Color.Black;
            drawBetButton.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            drawBetButton.Size = new Size(350, 55);
            drawBetButton.Location = new Point(0, 165);
            drawBetButton.FlatStyle = FlatStyle.Flat;
            drawBetButton.FlatAppearance.BorderSize = 0;
            drawBetButton.Click += DrawBetButton_Click;
            drawPanel.Controls.Add(drawBetButton);

            bettingContainerPanel.Controls.Add(drawPanel);

            contentPanel.Controls.Add(bettingContainerPanel);
            this.Controls.Add(contentPanel);

            // Bottom control panel
            Panel controlPanel = new Panel();
            controlPanel.BackColor = Color.FromArgb(50, 50, 50);
            controlPanel.Dock = DockStyle.Bottom;
            controlPanel.Height = 90;
            controlPanel.Padding = new Padding(20);

            Label controlLabel = new Label();
            controlLabel.Text = "Quick Actions:";
            controlLabel.ForeColor = Color.White;
            controlLabel.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            controlLabel.AutoSize = true;
            controlLabel.Location = new Point(20, 10);
            controlPanel.Controls.Add(controlLabel);

            Button loginButton = new Button();
            loginButton.Text = "Login";
            loginButton.BackColor = Color.FromArgb(70, 120, 180);
            loginButton.ForeColor = Color.White;
            loginButton.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            loginButton.Size = new Size(110, 50);
            loginButton.Location = new Point(20, 35);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.Click += LoginButton_Click;
            controlPanel.Controls.Add(loginButton);

            Button registerButton = new Button();
            registerButton.Text = "Register";
            registerButton.BackColor = Color.FromArgb(70, 120, 180);
            registerButton.ForeColor = Color.White;
            registerButton.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            registerButton.Size = new Size(110, 50);
            registerButton.Location = new Point(150, 35);
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.Click += RegisterButton_Click;
            controlPanel.Controls.Add(registerButton);

            Button payoutButton = new Button();
            payoutButton.Text = "Payout";
            payoutButton.BackColor = Color.FromArgb(70, 120, 180);
            payoutButton.ForeColor = Color.White;
            payoutButton.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            payoutButton.Size = new Size(110, 50);
            payoutButton.Location = new Point(280, 35);
            payoutButton.FlatStyle = FlatStyle.Flat;
            payoutButton.FlatAppearance.BorderSize = 0;
            payoutButton.Click += PayoutButton_Click;
            controlPanel.Controls.Add(payoutButton);

            Button exitButton = new Button();
            exitButton.Text = "Exit";
            exitButton.BackColor = Color.FromArgb(180, 80, 80);
            exitButton.ForeColor = Color.White;
            exitButton.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            exitButton.Size = new Size(110, 50);
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitButton.Location = new Point(controlPanel.ClientSize.Width - 130, 35);
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.Click += ExitButton_Click;
            controlPanel.Controls.Add(exitButton);

            this.Controls.Add(controlPanel);
        }

        private void MeronBetButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Placing bet on MERON...\nFunctionality coming soon!", "Meron Bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void WalaBetButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Placing bet on WALA...\nFunctionality coming soon!", "Wala Bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DrawBetButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Placing bet on DRAW...\nFunctionality coming soon!", "Draw Bet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Login functionality not implemented yet.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegisterButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Register functionality not implemented yet.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PayoutButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Payout functionality not implemented yet.", "Payout", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitButton_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
//type this shit in the terminal to run: dotnet run --project main.csproj