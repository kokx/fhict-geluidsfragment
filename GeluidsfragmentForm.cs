using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Hilversum
{
  public partial class GeluidsfragmentForm : Form
  {
    /******** datavelden ******************************************************/
    private BGExperience bgExperience;

    /******** constructor *****************************************************/
    public GeluidsfragmentForm()
    {
      InitializeComponent();
      bgExperience = new BGExperience("Dutch Design Week");
    }

    /******** methoden : event handlers ***************************************/


    private void btMaakAan_Click(object sender, EventArgs e)
    {
        if (!bgExperience.AddFragment(Convert.ToInt32(tbNr.Text), tbBestandsnaam.Text, tbTitel.Text, Convert.ToInt32(tbMin.Text), Convert.ToInt32(tbSec.Text))) {
            MessageBox.Show("Fragment met nr '" + tbNr.Text + "' bestaat al!");
        }
    }

    
    //Speel het juiste geluidsfragment af
    private void bntSpeel_Click(object sender, EventArgs e)
    {
        Geluidsfragment fragment = bgExperience.GetFragment(Convert.ToInt32(tbFragmentNr.Text));

        try {
            lbAfspeelInfo.Text = fragment.AlsString();

            fragment.Play();
        } catch (NullReferenceException ex) {
            MessageBox.Show("Nummer bestaat niet");
        }
    }

    private void btBrowse_Click(object sender, EventArgs e)
    {
      openFileDialog1.ShowDialog();
      tbBestandsnaam.Text = openFileDialog1.FileName;
    }

    private void toonInfo_Click(object sender, EventArgs e)
    {
        List<Geluidsfragment> fragmenten = bgExperience.GetAlleFragmenten();

        info.Items.Clear();

        foreach (Geluidsfragment fragment in fragmenten) {
            info.Items.Add(fragment.AlsString());
        }
    }

    private void zoeken_Click(object sender, EventArgs e)
    {
        List<Geluidsfragment> fragmenten = bgExperience.GetFragmenten(zoekwoord.Text);

        infoZoek.Items.Clear();

        foreach (Geluidsfragment fragment in fragmenten) {
            infoZoek.Items.Add(fragment.AlsString());
        }
    }
  }
}