//WARNING: This code was auto generated by template compiler, do not modify by hand!
//Generated on 28.01.2016 0:21:40 by NFX.Templatization.TextCSTemplateCompiler at SAMSON

using System; 
using System.Text; 
using System.Linq; 
using System.Collections.Generic; 

namespace WaveTestSite.Pages.SubTopic 
{

 ///<summary>
 /// Latest news page
 ///</summary>
 public  class Latest : WaveTestSite.Pages.Master
 {

    
    public override string Title { get {return "Latest news"; } }


     protected override void DoRender()
     {
       base.DoRender();
        Target.Write( Latest._1_S_LITERAL_0 );

     }
    protected override void  renderHeader()
    {
        Target.Write( Latest._1_S_LITERAL_1 );

    }
    protected override void  renderBody()
    {
        Target.Write( Latest._1_S_LITERAL_2 );
        Target.Write(Target.Encode( DateTime.Now ));
        Target.Write( Latest._1_S_LITERAL_3 );
      if (Context.SupportsSession)
  {
     Context.NeedsSession();
     if (!Context.Session.Items.ContainsKey("COUNTER2"))
        Context.Session.Items["COUNTER2"] = 0;

     var ctr = (int)Context.Session.Items["COUNTER2"];
     ctr++;
     Context.Session.Items["COUNTER2"] = ctr;


        Target.Write( Latest._1_S_LITERAL_4 );
        Target.Write(Target.Encode( ctr ));
        Target.Write( Latest._1_S_LITERAL_5 );
      }
        Target.Write( Latest._1_S_LITERAL_6 );

    }


     #region Literal blocks content
        private const string _1_S_LITERAL_0 = @"
"; 
        private const string _1_S_LITERAL_1 = @"
 <h1>
     Latest sub topic news
 </h1> 
"; 
        private const string _1_S_LITERAL_2 = @"
 <p> This page is latest news</p> 
 <p> This page is dynamically generated by the application server. </p> 
 <p> It is now "; 
        private const string _1_S_LITERAL_3 = @" </p> 
"; 
        private const string _1_S_LITERAL_4 = @"
   <p> You have visited this page "; 
        private const string _1_S_LITERAL_5 = @" times during this session</p>

"; 
        private const string _1_S_LITERAL_6 = @"


 <a href=""../welcome"">Welcome Page</a> |
 <a href=""../aboutus"">About Us Page</a>
&nbsp;"; 
     #endregion

 }//class
}//namespace
