//WARNING: This code was auto generated by template compiler, do not modify by hand!
//Generated on 28.01.2016 0:28:35 by NFX.Templatization.TextCSTemplateCompiler at SAMSON

using System; 
using System.Text; 
using System.Linq; 
using System.Collections.Generic; 

namespace WaveTestSite.Pages 
{

 ///<summary>
 /// Welcome page
 ///</summary>
 public  class RecordTest : WaveTestSite.Pages.Master
 {

    
    public override string Title { get {return "Welcome to NFX.Wave"; } }


     protected override void DoRender()
     {
       base.DoRender();
        Target.Write( RecordTest._67_S_LITERAL_0 );

     }
    protected override void  renderHeader()
    {
        Target.Write( RecordTest._67_S_LITERAL_1 );

    }
    protected override void  renderBody()
    {
        Target.Write( RecordTest._67_S_LITERAL_2 );
        Target.Write(Target.Encode( DateTime.Now ));
        Target.Write( RecordTest._67_S_LITERAL_3 );

    }


     #region Literal blocks content
        private const string _67_S_LITERAL_0 = @"
"; 
        private const string _67_S_LITERAL_1 = @"
 <h1>
     Welcome!
 </h1> 
<script src=""/stock/site/script/jquery-1.11.0.min.js""></script>
<script src=""/stock/site/script/wv.js""></script>
<script src=""/stock/site/script/wv.gui.js""></script>
"; 
        private const string _67_S_LITERAL_2 = @"
 <p> This page is dynamically generated by the application server. </p> 
 <p> It is now "; 
        private const string _67_S_LITERAL_3 = @" </p> 
 <a href=""welcome"">Welcome Page</a> |
<hr />

<style>
    .fView { display: block;  border: 1px solid #fefeb0;  padding: 4px; }
    label { margin: 4px; display: inline-block; }
    fieldset {  border: 1px solid #bfbfbf;  }

    .wvError { color: yellow; background: #ff8080; }
    .wvRequired {  font-weight: bold;  }

    .wvModified { border-bottom: 2px solid #0000ff;}


        .wvDialogBase {
            display: block;
            position: fixed;
            background: #3866de;
            border: 1px solid #808080;
            border-radius: 4px;
            padding: 6px;
            color: white;
            box-shadow: 6px 6px 10px #888888;
        }

        .wvDialogTitle {
            background: #2020c0;
            color: white;
            font-size: 1.37em;
            font-weight: bold;
            padding: 4px;
            border-radius: 4px;
        }

        .wvDialogContent {
            display: block;
            background: #fefef0;
            color: black;
            border: 1px solid #7070ff;
            padding: 4px;
            margin-top: 6px;
            border-radius: 4px;
            overflow: auto;
        }

        .wvToast {
            display: block;
            position: fixed;
            background: black;
            border: 1px solid #808080;
            width: auto;
            padding: 8px;
            top: 45%;
            left: 50%;
            color: white;
            box-shadow: 2px 2px 10px #888888;
        }

        .wvToast_warning {
            display: block;
            position: fixed;
            background: yellow;
            border: 1px solid #bcbc00;
            width: auto;
            padding: 8px;
            top: 45%;
            left: 50%;
            color: black;
            box-shadow: 2px 2px 10px #888888;
        }

        .wvToast_error {
            display: block;
            position: fixed;
            background: #ff2020;
            border: 1px solid #ff8080;
            width: auto;
            padding: 8px;
            top: 45%;
            left: 50%;
            color: white;
            box-shadow: 2px 2px 10px #888888;
        }

        .wvCurtain {
            background:url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAQAAAAECAYAAACp8Z5+AAAAF0lEQVQImWNgQAW+cAKJxs3xZWBgYAAANwIBz+0UkPgAAAAASUVORK5CYII=) repeat;
        }

        input[type=text],input[type=date],input[type=datetime],input[type=tel],select{
            width: 100%;
            background-color: #f0f0e0;
            border: 1px solid #808080;
        }

        input[type=text]:focus,input[type=date]:focus,input[type=datetime]:focus,input[type=tel]:focus,select:focus{
            background-color: #ffffc0;
            border: 1px solid #202020;
        }

        input[type=text]:disabled,input[type=date]:disabled,input[type=datetime]:disabled,input[type=tel]:disabled,select:disabled{
            background-color: #e0e0e0;
            color: #b0b0b0;
            border: 1px solid #808080;
        }


        .wvPuzzle {
            display: inline-block;
            width: auto;
        }
        .wvPuzzleHelp {
            display: block;
            border-top-left-radius: 12px;
            border-top-right-radius: 12px;
            background: #ff7070;
            color: white;
            border: 1px solid #808080;
            border-bottom: none;
            padding: 6px;
            font-size: 0.75em;
        }
        .wvPuzzleQuestion {
            display: block;
            border-top: none;
            border-bottom: none;
            background: #ff7070;
            color: white;
            border-left: 1px solid #808080;
            border-right: 1px solid #808080;
            padding: 6px;
            font-size: 1.2em;
            font-weight: bold;
        }

        .wvPuzzleInputs {
            display: block;
            border-top: none;
            border-bottom: none;
            background: #d0d0ff;
            border-left: 1px solid #808080;
            border-right: 1px solid #808080;
            padding: 4px;
        }

        .wvPuzzleInputs > input[type=""text""]:disabled {
            font-size: 2em;
            font-weight: bold;
            color: blue;
            background: white;
            width: 65%;
            height: 40px;
            padding: 0px;
            padding-left: 8px;
            padding-right: 8px;
            letter-spacing: 6px
        }
        .wvPuzzleInputs > button {
            font-size: 1.2em;
            font-weight: bold;
            width: 20%;
            height: 40px;
            float: right;
        }

        .wvPuzzleImg {
            display: block;
            border-bottom-left-radius: 12px;
            border-bottom-right-radius: 12px;
            background: #f8f8f8;
            border: 1px solid #808080;
            padding: 4px;
        }

        .wvPuzzleImg > img { margin-top: -20px; margin-bottom: -10px;  }



</style>
    <form data-wv-rid=""V1"" action=""/mvc/tester/person"" method=""post"">
       <table style=""width: 100%"">
        <tr>
        <td>
           <div class=""fView"" data-wv-fname=""ID""></div>
           <div class=""fView"" data-wv-fname=""FirstName""></div>
           <div class=""fView"" data-wv-fname=""LastName""></div>
           <div class=""fView"" data-wv-fname=""PubStatus""></div>
           <div class=""fView"" data-wv-fname=""PvtStatus""></div>
        </td>
        <td>
           <div class=""fView"" data-wv-fname=""DOB""></div>
           <div class=""fView"" data-wv-fname=""YearsInService""></div>
           <div class=""fView"" data-wv-fname=""Registered""></div>
           <div class=""fView"" data-wv-fname=""Salary""></div>
           <div class=""fView"" data-wv-fname=""Various"" data-wv-ctl=""radio""></div>
        </td>
        </tr>
        <tr>
        <td>
           <div class=""fView"" data-wv-fname=""Puzzle"" data-wv-ctl=""puzzle""></div>
        </td>
        <td>
           <input type=""submit"" value=""Submit"">
           <button onclick=""postAJAX(); return false;"">POST using AJAX</button>
        </td>
        </tr>
        </table>
    </form>


   
<script>
    var REC = null;
    var RVIEW = null;
    var xhr1 = new XMLHttpRequest();
        xhr1.open(""GET"", ""/mvc/tester/person"");
        xhr1.setRequestHeader('Content-Type', 'application/json');
        xhr1.onreadystatechange = function () {
            if (xhr1.readyState == 4 && xhr1.status == 200) {
                alert(""LOAD\n-------------\n""+xhr1.responseText);
                REC =  new WAVE.RecordModel.Record(JSON.parse(xhr1.responseText));
                RVIEW = new WAVE.RecordModel.RecordView(""V1"", REC);
            }
        }
        xhr1.send(""{PersonID: 123}"");
    
    function postAJAX(){
        var xhr = new XMLHttpRequest();
        xhr.open(""POST"", ""/mvc/tester/person"");
        xhr.setRequestHeader('Content-Type', 'application/json');
        xhr.onreadystatechange = function () {
            if (xhr.readyState == 4 && xhr.status == 200) {
               alert(xhr.responseText);
                RVIEW.destroyViews();
                REC =  new WAVE.RecordModel.Record(JSON.parse(xhr.responseText));
                RVIEW = new WAVE.RecordModel.RecordView(""V1"", REC);
            }
        }
       console.log(""SENT:  ""+JSON.stringify( REC.data() ));
       xhr.send(JSON.stringify(REC.data())); 
    }
    

</script>
       &nbsp;"; 
     #endregion

 }//class
}//namespace