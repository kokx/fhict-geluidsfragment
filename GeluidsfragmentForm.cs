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
      //TODO
    }

    
    //Speel het juiste geluidsfragment af
    private void bntSpeel_Click(object sender, EventArgs e)
    {
      //TODO
    }

    private void btBrowse_Click(object sender, EventArgs e)
    {
      openFileDialog1.ShowDialog();
      tbBestandsnaam.Text = openFileDialog1.FileName;
    }
  }
}