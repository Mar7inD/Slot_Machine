using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(0, 7);
        }
        public Form1()
        {
            
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            int a = 5, g = 10, h = 15;
            int l = 0;
            int k = Int32.Parse(lblMoney.Text);
          
            if (k <= 4) 
            { MessageBox.Show("Not enough money"); }
            
            else
            {
                SlotA.Image = SlotMachine.Properties.Resources.animation;
                SlotB.Image = SlotMachine.Properties.Resources.animation;
                SlotC.Image = SlotMachine.Properties.Resources.animation;
                if (radioButton1.Checked) 
                { l = k - a; lbl2.Text = "10"; lbl3.Text = "15"; }
                
                else if (radioButton2.Checked) 
                { l = k - g; lbl2.Text = "20"; lbl3.Text = "30"; }
                
                else if (radioButton3.Checked) 
                { l = k - h; lbl2.Text = "30"; lbl3.Text = "45"; }
                lblMoney.Text = l.ToString();
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
                int l = 0;
                int k = Int32.Parse(lblMoney.Text);
                
                Random random = new Random();
                int m = random.Next(0, 7);
                int n = random.Next(0, 7);
                int b = random.Next(0, 7);

                switch (m)
                {
                    
                case 0:
                        SlotA.Image = SlotMachine.Properties.Resources.apple;
                    SlotA.Tag = "8";
                    break;
                   
                case 1:
                        SlotA.Image = SlotMachine.Properties.Resources.banana;
                    SlotA.Tag = "1";
                    break;
                   
                case 2:
                        SlotA.Image = SlotMachine.Properties.Resources.bar;
                    SlotA.Tag = "2";
                    break;
                   
                case 3:
                        SlotA.Image = SlotMachine.Properties.Resources.cherry;
                    SlotA.Tag = "3";
                    break;
                   
                case 4:
                        SlotA.Image = SlotMachine.Properties.Resources.grape;
                    SlotA.Tag = "4";
                    break;

                case 5:
                        SlotA.Image = SlotMachine.Properties.Resources.lemon;
                    SlotA.Tag = "5";
                    break;
                   
                case 6:
                        SlotA.Image = SlotMachine.Properties.Resources.melon;
                    SlotA.Tag = "6";
                    break;
                   
                case 7:
                        SlotA.Image = SlotMachine.Properties.Resources.pear;
                    SlotA.Tag = "7";
                    break;
                   
                default:
                        SlotA.Image = SlotMachine.Properties.Resources.animation;
                    SlotA.Tag = "0";
                    break;
                }


                switch (n)
                {
                   
                case 0:
                        SlotB.Image = SlotMachine.Properties.Resources.apple;
                    SlotB.Tag = "8";
                    break;
                  
                case 1:
                        SlotB.Image = SlotMachine.Properties.Resources.banana;
                    SlotB.Tag = "1";
                    break;
                   
                case 2:
                        SlotB.Image = SlotMachine.Properties.Resources.bar;
                    SlotB.Tag = "2";
                    break;
                    
                case 3:
                        SlotB.Image = SlotMachine.Properties.Resources.cherry;
                    SlotB.Tag = "3";
                    break;
                  
                case 4:
                        SlotB.Image = SlotMachine.Properties.Resources.grape;
                    SlotB.Tag = "4";
                    break;
                   
                case 5:
                        SlotB.Image = SlotMachine.Properties.Resources.lemon;
                    SlotB.Tag = "5";
                    break;
                    
                case 6:
                        SlotB.Image = SlotMachine.Properties.Resources.melon;
                    SlotB.Tag = "6";
                    break;
                    
                case 7:
                        SlotB.Image = SlotMachine.Properties.Resources.pear;
                    SlotB.Tag = "7";
                    break;
                    
                default:
                        SlotB.Image = SlotMachine.Properties.Resources.animation;
                    SlotB.Tag = "0";
                    break;
                }
                switch (b)
                {
                
                case 0:
                        SlotC.Image = SlotMachine.Properties.Resources.apple;
                    SlotC.Tag = "8";
                        break;
                
                case 1:
                        SlotC.Image = SlotMachine.Properties.Resources.banana;
                    SlotC.Tag = "1";
                    break;
                    
                case 2:
                        SlotC.Image = SlotMachine.Properties.Resources.bar;
                    SlotC.Tag = "2";
                    break;
                    
                case 3:
                        SlotC.Image = SlotMachine.Properties.Resources.cherry;
                    SlotC.Tag = "3";
                    break;
                
                case 4:
                        SlotC.Image = SlotMachine.Properties.Resources.grape;
                    SlotC.Tag = "4";
                    break;
                    
                case 5:
                        SlotC.Image = SlotMachine.Properties.Resources.lemon;
                    SlotC.Tag = "5";
                    break;
                    
                case 6:
                        SlotC.Image = SlotMachine.Properties.Resources.melon;
                    SlotC.Tag = "6";
                    break;
                
                case 7:
                        SlotC.Image = SlotMachine.Properties.Resources.pear;
                    SlotC.Tag = "7";
                    break;
                    
                default:
                        SlotB.Image = SlotMachine.Properties.Resources.animation;
                    SlotC.Tag = "0";
                    break;
            }
            if (radioButton1.Checked)
            {
                if (SlotA.Tag == SlotB.Tag || SlotA.Tag == SlotC.Tag || SlotC.Tag == SlotB.Tag)
                {
                    if (SlotA.Tag == SlotB.Tag && SlotA.Tag == SlotC.Tag && SlotC.Tag == SlotB.Tag) { l = l + 15; }
                    else { l = l + 10; }
                }

            }

            else if (radioButton2.Checked)
            {
                if (SlotA.Tag == SlotB.Tag || SlotA.Tag == SlotC.Tag || SlotC.Tag == SlotB.Tag) 

                {
                    if (SlotA.Tag == SlotB.Tag && SlotA.Tag == SlotC.Tag && SlotC.Tag == SlotB.Tag) { l = l + 30; }
                    else { l = l + 20; }
                }
            }

            else if (radioButton3.Checked)
            {
                if (SlotA.Tag == SlotB.Tag || SlotA.Tag == SlotC.Tag || SlotC.Tag == SlotB.Tag) 

                {
                    if (SlotA.Tag == SlotB.Tag && SlotA.Tag == SlotC.Tag && SlotC.Tag == SlotB.Tag) { l = l + 45; }
                    else { l = l + 30; }
                }
            }
            l = k + l;
            lblMoney.Text = l.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int k = Int32.Parse(lblMoney.Text);
            int n = Int32.Parse(txtMoney.Text);
            int p = 0;
            if (n <= 0 || n > 1000 || n % 5 != 0) 
            { MessageBox.Show("The value you want to add is lower or equal to 0 or is higher than 1000 or it can't be divided by 5"); }
            
            else { p = k + n; lblMoney.Text = p.ToString(); int u = Int32.Parse(lblMoney.Text);
                if (p > 1000) { MessageBox.Show("The value of your money is higher than 1000 and we exported it to your account."+"We transfered "+ p +" $ to your bank account");lblMoney.Text = "0"; }
                    
                        }
            
            txtMoney.Text = "";
        }
    }
}

