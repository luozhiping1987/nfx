//WARNING: This code was auto generated by template compiler, do not modify by hand!
//Generated on 28.01.2016 0:21:31 by NFX.Templatization.TextCSTemplateCompiler at SAMSON

using System; 
using System.Text; 
using System.Linq; 
using System.Collections.Generic; 

namespace NFX.Wave.Templatization.StockContent 
{

 ///<summary>
 /// Displays good-looking 404 page
 ///</summary>
 public  class Error : NFX.Wave.Templatization.StockContent.Master
 {

    
    public readonly Exception ErrorCause;
    public readonly bool ShowDump;

    public Error(WorkContext work, Exception error, bool showDump) : base(work)
    {
        ErrorCause = error;
        ShowDump = showDump;
    }

    public override string Title { get {return "NFX.Wave Error"; } }


     protected override void DoRender()
     {
       base.DoRender();
        Target.Write( Error._43_S_LITERAL_0 );

     }
    protected override void  renderHeader()
    {
        Target.Write( Error._43_S_LITERAL_1 );
      if (ShowDump){
        Target.Write( Error._43_S_LITERAL_2 );
        Target.Write(Target.Encode( "'{0}' Error".Args(ErrorCause.GetType().Name) ));
        Target.Write( Error._43_S_LITERAL_3 );
      }else{
        Target.Write( Error._43_S_LITERAL_4 );
      }
        Target.Write( Error._43_S_LITERAL_5 );

    }
    protected override void  renderBody()
    {
        Target.Write( Error._43_S_LITERAL_6 );
      if (ShowDump)
      { 
        showDumpBody();
        return;
      }
        Target.Write( Error._43_S_LITERAL_7 );

    }
    protected void showDumpBody()
    {
        Target.Write( Error._43_S_LITERAL_8 );
        Target.Write(Target.Encode( Context.Match!=null?Context.Match.Name : "[no match]" ));
        Target.Write( Error._43_S_LITERAL_9 );
      showException(ErrorCause);
        Target.Write( Error._43_S_LITERAL_10 );

    }
    protected void showException(Exception err)
    {
        Target.Write( Error._43_S_LITERAL_0 );
      if(err==null) return;
        Target.Write( Error._43_S_LITERAL_11 );
        Target.Write(Target.Encode( err.GetType().FullName ));
        Target.Write( Error._43_S_LITERAL_12 );
        Target.Write(Target.Encode( err.Message ));
        Target.Write( Error._43_S_LITERAL_13 );
      if(err is HTTPStatusException)
      {
        var se = err as HTTPStatusException;
        Target.Write( Error._43_S_LITERAL_14 );
        Target.Write(Target.Encode( se.StatusCode ));
        Target.Write( Error._43_S_LITERAL_15 );
        Target.Write(Target.Encode( se.StatusDescription ));
        Target.Write( Error._43_S_LITERAL_16 );
      }
        Target.Write( Error._43_S_LITERAL_17 );
        Target.Write(Target.Encode( err.StackTrace ));
        Target.Write( Error._43_S_LITERAL_18 );
      if (err is FilterPipelineException){
        Target.Write( Error._43_S_LITERAL_19 );
      showException(((FilterPipelineException)err).RootException);
        Target.Write( Error._43_S_LITERAL_6 );
      }else
     {
      var inner = err.InnerException;
      if (inner==null) return;
     
        Target.Write( Error._43_S_LITERAL_20 );
      showException(inner);
        Target.Write( Error._43_S_LITERAL_21 );
      }
        Target.Write( Error._43_S_LITERAL_22 );

    }


     #region Literal blocks content
        private const string _43_S_LITERAL_0 = @"
"; 
        private const string _43_S_LITERAL_1 = @"
 <h1>
     "; 
        private const string _43_S_LITERAL_2 = @"
       "; 
        private const string _43_S_LITERAL_3 = @"
     "; 
        private const string _43_S_LITERAL_4 = @"
       OOPS! An Error Occured
     "; 
        private const string _43_S_LITERAL_5 = @"
 </h1> 
"; 
        private const string _43_S_LITERAL_6 = @"
    "; 
        private const string _43_S_LITERAL_7 = @"
 <p> An error happened while generating the page. We apologize for inconvenience. </p> 
 <p> The error details may have been logged. Please consult with your web guru! </p> 

"; 
        private const string _43_S_LITERAL_8 = @"
<div>
    <strong>Handler Match:</strong> "; 
        private const string _43_S_LITERAL_9 = @"<br />

    "; 
        private const string _43_S_LITERAL_10 = @"

 </div>
"; 
        private const string _43_S_LITERAL_11 = @"
    <strong>Type:</strong> "; 
        private const string _43_S_LITERAL_12 = @"<br />
    <strong>Message:</strong> "; 
        private const string _43_S_LITERAL_13 = @"<br />
    
    "; 
        private const string _43_S_LITERAL_14 = @"
     <strong>Http Status Code:</strong> "; 
        private const string _43_S_LITERAL_15 = @"<br />
     <strong>Http Status Description:</strong> "; 
        private const string _43_S_LITERAL_16 = @"<br />
    "; 
        private const string _43_S_LITERAL_17 = @" 
     
    <strong>Stack Trace:</strong><br /> 
     <div class=""stackTrace"">
     "; 
        private const string _43_S_LITERAL_18 = @"
     </div> 
    
    
    "; 
        private const string _43_S_LITERAL_19 = @"
      <br />      
      <strong>Root Exception:</strong>
          
      <hr />
      "; 
        private const string _43_S_LITERAL_20 = @"
    <br />    
    <strong>Inner Exception:</strong>    
    <hr />
    "; 
        private const string _43_S_LITERAL_21 = @" 
    "; 
        private const string _43_S_LITERAL_22 = @"
   &nbsp;"; 
     #endregion

 }//class
}//namespace
