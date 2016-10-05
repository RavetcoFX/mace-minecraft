﻿/*
    Mace
    Copyright (C) 2011 Robson
    http://iceyboard.no-ip.org

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Windows.Forms;
using System.IO;

namespace Mace
{
    partial class frmAbout : Form
    {
        private const string URL_PROJECT_SITE = "http://code.google.com/p/mace-minecraft/";
        private const string URL_FORUM_TOPIC = "http://www.minecraftforum.net/topic/357201-mace-v11-random-city-generator/";
        private const string URL_ROBSON = "http://iceyboard.no-ip.org";
        private const string URL_CREDITS = "http://code.google.com/p/mace-minecraft/wiki/Credits";

        public frmAbout()
        {
            InitializeComponent();
            Version ver = System.Reflection.Assembly.GetEntryAssembly().GetName().Version;
            this.lblApplication.Text = String.Format("Mace v{0}.{1}.{2}", ver.Major, ver.Minor, ver.Build);
            picWires.Load(Path.Combine("Resources", "wires.gif"));
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 1000000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.lnkProjectSite, URL_PROJECT_SITE);
            toolTip1.SetToolTip(this.lnkForumTopic, URL_FORUM_TOPIC);
            toolTip1.SetToolTip(this.lnkRobson, URL_ROBSON);
            toolTip1.SetToolTip(this.lnkCredits, URL_CREDITS);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void lnkProjectSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(URL_PROJECT_SITE);
        }
        private void lnkForumTopic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(URL_FORUM_TOPIC);
        }
        private void lnkRobson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(URL_ROBSON);
        }
        private void lnkCredits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(URL_CREDITS);
        }
    }
}