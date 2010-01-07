using System;
using System.Collections.Generic;
using System.Text;

namespace Hilversum
{
  class BGExperience
  {
    /******** datavelden ******************************************************/

    private List<Geluidsfragment> fragmenten;
    private String thema;

    /******** constructoren ***************************************************/
    public BGExperience(String thema)
    {
      fragmenten = new List<Geluidsfragment>();
      this.thema = thema;
    }

    /******** properties ********************************************************/

    //alleen een getter
    //de getter retourneert het thema
    public String Thema
    {
        //TODO
    }

      /******** methoden ********************************************************/
   
    // returns het geluidsfragment met nummer nr, 
    // tenzij dat niet bekend is, dan wordt er null geretourneerd
    public Geluidsfragment GetFragment(int nr)
    {
      //TODO
    }

    // returns een list met alle geluidsfragmenten.
    public List<Geluidsfragment> GetAlleFragmenten()
    {
        return fragmenten;
    }
      
    // returns een list met alle geluidsfragmenten met patroon p in de titel.
    public List<Geluidsfragment> GetFragment(String p)
    {
        //TODO
        //Hint: Maak gebruik van de methode IndexOf van een String om te
        //achterhalen of een zeker patroon voor komt in een string.
    }

    // indien het opgegeven nummer nr nog niet is toegewezen aan een ander geluidsfragment,
    // dan: wordt een geluidsfragment met de overgedragen gegevens gecreeerd en
    // bij aan de list fragmenten toegevoegd; de returnwaarde is dan true,
    // anders: er is geen nieuw Geluidsfragment-object toegevoegd en de
    // teturnwaarde is false
    public bool AddFragment(int nr, String bestandsnaam, String titel, int min, int sec) 
    {
      // TODO 
    }

  }
}
