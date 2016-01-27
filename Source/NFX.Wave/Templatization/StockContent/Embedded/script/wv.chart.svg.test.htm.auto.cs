//WARNING: This code was auto generated by template compiler, do not modify by hand!
//Generated on 28.01.2016 0:36:28 by NFX.Templatization.TextCSTemplateCompiler at SAMSON

using System; 
using System.Text; 
using System.Linq; 
using System.Collections.Generic; 

namespace id_17442_template_371 
{

 ///<summary>
 /// Auto-generated from template
 ///</summary>
 public  class wv_chart_svg_test : NFX.Templatization.Template<object, NFX.Templatization.IRenderingTarget, object>
 {

     protected override void DoRender()
     {
       base.DoRender();
        Target.Write( wv_chart_svg_test._56_S_LITERAL_0 );

     }


     #region Literal blocks content
        private const string _56_S_LITERAL_0 = @"<!--
#1 add mode upper/lower fill for LS
#2 series: add ""show point title"" prop (maybe angle 0, 90 depending on point pos on chart)
#3 embeded chart tooltip ( for example, for point description) with tooltip message formating
-->

<html>
<head>
  <title>wvchart test</title>
  <style type=""text/css"">
    /*line {shape-rendering: crispEdges; }
    rect {shape-rendering: crispEdges; }*/

    /*html, body {
      margin: 0; padding: 0;
    }*/

    rect.wvSvgBkgr { fill: #f9f6f6; }
    line.wvAxisLine { stroke: #000000; stroke-width: 1; }
    line.wvAxisTickLine { stroke: #000000;}

    line.wvGridLine { stroke: #cccccc; stroke-width: 1; stroke-dasharray: 2,2; }
    /*wvGridXLine { stroke: #000000; stroke-width: 1; }*/

    rect.wvXZoneBackground { fill: #e6e9e9; }
    text.wvAxisLabel { fill: #000000; font-family: verdana, sans-serif; font-size: 10px; text-anchor: start; }
    text.wvYAxisLabel { fill: #000000; font-size: 10px; text-anchor: end; }

    rect.wvYZoneBackground { fill: #e9e6e6; }

    rect.wvSZoneBackground { fill: #ffffff; }

    path.wvSeriesLine { stroke: #ff8080; fill: none; stroke-width: 7px; stroke-linejoin: round; }
    path.wvSeriesLineArea { stroke: #ff8080; fill: rgba(255, 150, 60, 0.44); }

    path.wvSeriesLine-1 { stroke: #80ff80; fill: none;  stroke-width: 3px; stroke-linejoin: bevel; }
    path.wvSeriesLineArea-1 { stroke: #80ff80; fill: rgba(115, 245, 115, 0.44); }

    path.wvSeriesLine-2 { stroke: #8080ff; fill: none;  stroke-width: 3px; stroke-linejoin: bevel; }
    path.wvSeriesLineArea-2 { stroke: #8080ff; fill: rgba(25, 61, 235, 0.47) ; }

    rect.wvSeriesRect { fill: #aaaa00; }
    rect.series-rect-1 { fill: #0000aa; }
    rect.series-rect-2 { fill: #00aa00; }

    .wvSeriesPoint { fill: #000000; }
    .series-point-0 { fill: #ff8080; }
    .series-point-1 { fill: #80ff80; }
    .series-point-2 { fill: #8080ff; }


    .wvChartPointTitle rect { fill: rgba(255, 200, 200, 0.75); stroke: rgba(0, 0, 0, 0.5); }
    .wvChartPointTitle text { fill: #9090ff; font-family: Verdana; font-size: 14px; }
    .wvChartPointTitle line {
      stroke: #808090;
      marker-start: url(#markerLegStart);
      marker-end: url(#markerLegEnd);
    }

    .wvChartPointTitle-1 rect { fill: rgba(200, 255, 200, 0.75); stroke: rgba(0, 0, 0, 0.5); }
    .wvChartPointTitle-1 text { fill: #9090ff; font-family: Verdana; font-size: 14px; }
    .wvChartPointTitle-1 line {
      stroke: #808090;
      marker-start: url(#markerLegStart);
      marker-end: url(#markerLegEnd);
    }

    .wvChartPointTitle-2 rect { fill: rgba(200, 200, 255, 0.75); stroke: rgba(0, 0, 0, 0.5); }
    .wvChartPointTitle-2 text { fill: #9090ff; font-family: Verdana; font-size: 14px; }
    .wvChartPointTitle-2 line {
      stroke: #808090;
      marker-start: url(#markerLegStart);
      marker-end: url(#markerLegEnd);
    }


    rect.wvLZoneBackground { fill: #ffffff; stroke: #000000;}
    text.wvLegendName { fill: #000000; font-family: verdana, sans-serif; font-size: 9px; }


    div.chart {
      float: left;
      width: 60%;
      background-color: #bbbbee;
      margin: 0; padding: 0;
      border: none;
      overflow: auto;
    }
    svg {
      border: none;
      margin: 0; padding: 0;
    }
    input[type=number] { width: 55px; }
    #lZone {
      width: 200px;
      clear: both;
    }
    #lZone input {
      width: 100%;
      clear: both;
    }
    .field {
      margin: 3px;
    }
    div.manage {
      float: right;
      background-color: #eeeeee;
      width: 40%;
    }
      div.manage fieldset { display: table; }
      div.manage p { display: table-row; }
      div.manage label { display: table-cell; width: 150px; }
      div.manage input { display: table-cell }

    .wvToast {
      background-color: rgba(115, 245, 115, 0.44);
      border: 1px solid black;
      position: absolute;
    }

    .wvRulerHint {
      background-color: rgba(238, 238, 204, .8);
      border: 1px solid #aaaaaa;
      border-radius: 3px;
      padding: 2px;
      pointer-events: none;
      z-index: 10000;
    }

    .wvRulerSight {
      border-left: 1px dashed #444444; 
      border-top: 1px dashed #444444;
      pointer-events: none;
      z-index: 9999;
    }
  </style>
  <script src=""jquery-2.1.4.min.js""></script>
  <script src=""wv.js""></script>
  <script src=""wv.gui.js""></script>
  <script src=""wv.chart.svg.js""></script>
  <script type=""text/javascript"">
    var svgEl;

    var lZoneLegendMargin;

    WAVE.GUI.rulerSetScope("""", {});

    function initSvg2() {
      svgEl = $(""#svg2"")[0];

      var chart = new WAVE.Chart.SVG.Chart(svgEl);

      var series0 = chart.addSeries({ title: ""Series 0 common language runtime"", pointClass: ""series-point-0"", showPointTitleLeg: false });

      chart.beginUpdate();

      chart.sZone().chartType(WAVE.Chart.SVG.ChartType.LINE);
      chart.xAxis().dataType(WAVE.Chart.SVG.DataType.DATE);

      chart.xAxis().isBottom(false);
      chart.yAxis().isLeft(false);
      chart.lZone().corner(WAVE.Chart.SVG.RectCorner.LEFTTOP);
      chart.sZone().showPointTitle(true);

      chart.yAxis().minWidth(50);

      function pad(n) { return n < 10 ? '0' + n : n }
      chart.xAxis().labelValToStr = function (dt) {
        return (pad(dt.getHours())) + "":"" + pad(dt.getMinutes()) + "":"" + pad(dt.getSeconds());
      };


      series0.dataSet().addPoint(new Date(""2014/09/23 12:00""), 0, ""1st point"");
      series0.dataSet().addPoint(new Date(""2014/09/23 12:20""), .003, ""2nd point"");
      series0.dataSet().addPoint(new Date(""2014/09/23 12:40""), .003, ""3rd point"");
      series0.dataSet().addPoint(new Date(""2014/09/23 13:00""), .003, ""4th point"");

      chart.sZone().attachToRulerScope("""");

      chart.endUpdate();

      return chart;
    }

    $(function () {
      var chart2 = initSvg2();

      svgEl = $(""#svg1"")[0];
      
      var chart = new WAVE.Chart.SVG.Chart(svgEl);

      chart.beginUpdate();

      chart.sZone().chartType(WAVE.Chart.SVG.ChartType.LINE);
      //chart.xAxis().min(new Date(""2014/09/23 12:00"")); chart.xAxis().max(new Date(""2014/09/23 13:00""));
      //chart.xAxis().minMargin(60); chart.xAxis().maxMargin(60);
      //chart.yAxis().min(0); chart.yAxis().max(100);
      //chart.yAxis().minMargin(1); chart.yAxis().maxMargin(1);
      //chart.xAxis().getMinMax = function () {
      //  var now = new Date();
      //  return {min: new Date(now.getTime() -25 * 1000), max: now };
      //};
      chart.xAxis().dataType(WAVE.Chart.SVG.DataType.DATE);

      //chart.yAxis().isLinear(false);

      chart.yAxis().minWidth(50);
      
      chart.xAxis().isBottom(false);
      //chart.yAxis().isLeft(false);
      chart.lZone().corner(WAVE.Chart.SVG.RectCorner.LEFTTOP);
      //chart.yZone().enabled(false);
      //chart.xZone().enabled(false);
      chart.sZone().showPointTitle(true);

      function pad(n) { return n < 10 ? '0' + n : n }
      chart.xAxis().labelValToStr = function (dt) { 
        return (pad(dt.getHours()))+"":""+pad(dt.getMinutes())+"":""+pad(dt.getSeconds());
      };

      function pointClickDialog(evt) {
        var template = ""<div style='width: 200px; padding: 7px; background-color: #aaaaaa;'>"" + 
                  ""  <div>"" +
                  ""    <p>Series: @series@</p>"" +
                  ""    <p>Title: @title@</p>"" +
                  ""    <p>vX: @vx@</p>"" +
                  ""    <p>vY: @vy@</p>"" +
                  ""    <p>dX: @dx@</p>"" +
                  ""    <p>dY: @dy@</p>"" +
                  ""  <div>"" +
                  ""  <button onclick='WAVE.GUI.currentDialog().cancel()'>Close</button>"" +
                  ""</div>"";

        var html = WAVE.strTemplate(template, {
          series: evt.series.title(),
          title: evt.title,
          vx: evt.vx, vy: evt.vy,
          dx: evt.dx, dy: evt.dy
        });

        new WAVE.GUI.Dialog({title: ""Point Click"", content: html});
      }

      function pointMouseOverToast(evt) {
        var currDlg = WAVE.GUI.currentDialog();
        if (currDlg) currDlg.cancel();
        WAVE.GUI.toast(evt.series.title() + "": "" + evt.title + ""["" + evt.dx + "", "" + evt.dy + ""]"");
        $("".wvToast"").last().offset({top: evt.originalEvt.clientX, left: evt.originalEvt.clientY});
      }

      //chart.eventBind(WAVE.Chart.SVG.EVT_SERIES_POINT_MOUSEOVER, function(evt) { console.log(""EVT_SERIES_POINT_MOUSEOVER""); });
      //chart.eventBind(WAVE.Chart.SVG.EVT_SERIES_POINT_MOUSEOUT, function(evt) { console.log(""EVT_SERIES_POINT_MOUSEOUT""); });
      //chart.eventBind(WAVE.Chart.SVG.EVT_SERIES_POINT_CLICK, function(evt) { console.log(""EVT_SERIES_POINT_CLICK""); });

      //chart.eventBind(WAVE.Chart.SVG.EVT_SERIES_POINT_TITLE_MOUSEOVER, function(evt) { console.log(""EVT_SERIES_POINT_TITLE_MOUSEOVER""); });
      //chart.eventBind(WAVE.Chart.SVG.EVT_SERIES_POINT_TITLE_MOUSEOUT, function(evt) { console.log(""EVT_SERIES_POINT_TITLE_MOUSEOUT""); });
      //chart.eventBind(WAVE.Chart.SVG.EVT_SERIES_POINT_TITLE_CLICK, function(evt) { console.log(""EVT_SERIES_POINT_TITLE_CLICK""); });

      var series0 = chart.addSeries({ title: ""Series 0 common language runtime"", pointClass: ""series-point-0"", showPointTitleLeg: false });
      //var series1 = chart.addSeries({ title: ""Series 1"", class: ""wvSeries-1"", lineClass: ""wvSeriesLine-1"", lineSquareClass: ""wvSeriesLineArea-1"", 
      //  pointClass: ""series-point-1"", pointTitleClass: ""wvChartPointTitle-1"", showPointTitleLeg: true  });
      //var series2 = chart.addSeries({ title: ""Series 2"", lineClass: ""wvSeriesLine-2"", lineSquareClass: ""wvSeriesLineArea-2"", 
      //  pointClass: ""series-point-2"", pointTitleClass: ""wvChartPointTitle-2"", showPointTitleLeg: false  });

        

        series0.dataSet().addPoint(new Date(""2014/09/23 12:00""), 0, ""1st point"");
        series0.dataSet().addPoint(new Date(""2014/09/23 12:20""), 10, ""2nd point"");
        series0.dataSet().addPoint(new Date(""2014/09/23 12:40""), 100, ""3rd point"");
        series0.dataSet().addPoint(new Date(""2014/09/23 13:00""), 150, ""4th point"");

        //series1.dataSet().addPoint(new Date(""2014/09/23 13:00""), 20);
        //series1.dataSet().addPoint(new Date(""2014/09/23 14:00""), 80);
        //series1.dataSet().addPoint(new Date(""2014/09/23 15:00""), 70);
        //series1.dataSet().addPoint(new Date(""2014/09/23 17:00""), 50);

        //console.log(new Date(""2014/09/23 13:00"").toLocaleString());
        //series0.dataSet().addPoint(new Date(""2014/09/23 15:00""), 100);
        //series0.dataSet().addPoint(new Date(""2014/09/23 16:00""), 500);
        //series0.dataSet().addPoint(new Date(""2014/09/23 17:00""), 50);


      chart.sZone().attachToRulerScope("""");
      chart.endUpdate();

      function syncButtons() {
        if (timer != null) {
          $(""#btnStart"").attr('disabled', 'disabled');
          $(""#btnStop"").removeAttr('disabled');
        } else {
          $(""#btnStop"").attr('disabled', 'disabled');
          $(""#btnStart"").removeAttr('disabled');
        }
      }

      var DATA_Y = null;

      $(document).mousemove(function(evt) { DATA_Y = evt.pageY });

      function drawChart() {
        chart.beginUpdate();

        var threshold = new Date(new Date().getTime() - 25 * 1000);
        function processSeries(ds) {
          ds.removePointIf(function(p) { return p.x < threshold });
          ds.addPoint(new Date(), DATA_Y + (Math.random() * 50), Math.random() > .8 ? ""Ptica #"" : null);
        }

        chart.seriesListWalkable().wWhere(function(s) { return s.title() != ""Series 2"" }).wSelect(function(s) { return s.dataSet() }).wEach(processSeries);

        chart.endUpdate();
      }

      $(""#btnDraw"").click(function() {drawChart();});

      $(""#btnStart"").click(function () {
        timer = setInterval(function () {
          drawChart();
        }, 500);
        syncButtons();
      });

      $(""#btnStop"").click(function () {
        clearInterval(timer);
        timer = null;
        syncButtons();
      });

      $(""#xAxisIsBottom"").prop(""checked"", chart.xAxis().isBottom());
      $(""#xAxisIsBottom"").change(function () { chart.xAxis().isBottom(this.checked) });

      //$(""#sZoneShowRuler"").prop(""checked"", chart.sZone().showRuler());
      //$(""#sZoneShowRuler"").change(function () { chart.sZone().showRuler(this.checked) });
      $(""#sZoneShowRuler"").prop(""checked"", chart.sZone().rulerScopes().length > 0);
      $(""#sZoneShowRuler"").change(function () {
        chart.sZone().showDefaultRuler(this.checked);
        chart2.sZone().showDefaultRuler(this.checked);
        //if (chart.sZone().rulerScopes().length == 0) {
        //  //chart.sZone().attachToRulerScope("""");
        //  //chart.sZone().showDefaultRuler();
        //} else {
        //  //chart.sZone().detachFromRulerScope("""");
        //}
      });

      lZoneLegendMargin = $(""#lZoneLegendMargin"")[0];
      lZoneLegendMargin.value = chart.lZone().legendMargin();
      $(""#lZoneLegendMargin"").bind(""keyup input"", function() {  
        var val = parseInt(lZoneLegendMargin.value);
        chart.lZone().legendMargin(val);
      });

      lZoneSeriesMargin = $(""#lZoneSeriesMargin"")[0];
      lZoneSeriesMargin.value = chart.lZone().seriesMargin();
      $(""#lZoneSeriesMargin"").bind(""keyup input"", function() {  
        var val = parseInt(lZoneSeriesMargin.value);
        chart.lZone().seriesMargin(val);
      });

      $(""input:radio[name=lZoneCorner]"")[chart.lZone().corner()].checked = true;
      $(""input:radio[name=lZoneCorner]"").change(function(){ chart.lZone().corner(WAVE.Chart.SVG.RectCorner[this.value]) });

      $(""#chkChartTypePoint"").prop(""checked"", chart.sZone().chartType() & WAVE.Chart.SVG.ChartType.POINT);
      $(""#chkChartTypeLine"").prop(""checked"", chart.sZone().chartType() & WAVE.Chart.SVG.ChartType.LINE);
      $(""#chkChartTypePoint, #chkChartTypeLine, #chkChartTypeSpline, #chkChartTypeLineSquare, #chkChartTypeSplineSquare, #chkChartTypeBar"").change(function(evt) { 
        if (this.checked)
          chart.sZone().chartType( chart.sZone().chartType() | WAVE.Chart.SVG.ChartType[this.value]);
        else
          chart.sZone().chartType( chart.sZone().chartType() & ~WAVE.Chart.SVG.ChartType[this.value]);
      });

      $(""input:radio[name=sZonePointType]"")[chart.sZone().pointType()].checked = true;
      $(""input:radio[name=sZonePointType]"").change(function(){ chart.sZone().pointType(WAVE.Chart.SVG.PointType[this.value]) });
      $(""#sZonePointSize"").val(chart.sZone().pointSize());
      $(""#sZonePointSize"").change(function() { chart.sZone().pointSize( parseInt(this.value))});

      $(""input:radio[name=sZoneSquareFillType]"")[Math.round(Math.log(chart.sZone().squareFillType()) / Math.LN2)].checked = true;
      $(""input:radio[name=sZoneSquareFillType]"").change(function(){ 
        chart.sZone().squareFillType(WAVE.Chart.SVG.SquareFillType[this.value]) 
      });

      $(""#sZoneShowPointTooltip"").prop(""checked"", chart.sZone().showPointTooltip());
      $(""#sZoneShowPointTooltip"").change(function(){ chart.sZone().showPointTooltip(this.checked) });
      $(""#sZonePointTooltipFormat"").val(chart.sZone().pointTooltipFormat());
      $(""#sZonePointTooltipFormat"").change(function() { chart.sZone().pointTooltipFormat(this.value)});

      $(""#sZoneShowPointTitle"").prop(""checked"", chart.sZone().showPointTitle());
      $(""#sZoneShowPointTitle"").change(function(){ chart.sZone().showPointTitle(this.checked) });
      $(""#sZonePointTitleFormat"").val(chart.sZone().pointTitleFormat());
      $(""#sZonePointTitleFormat"").change(function() { chart.sZone().pointTitleFormat(this.value)});
      $(""#sZonePointTitleAngle"").val(chart.sZone().pointTitleAngle());
      $(""#sZonePointTitleAngle"").change(function() { chart.sZone().pointTitleAngle(this.value)});
      $(""#sZonePointTitleMargin"").val(chart.sZone().pointTitleMargin());
      $(""#sZonePointTitleMargin"").change(function() { chart.sZone().pointTitleMargin( parseInt(this.value))});

      $(""#sZoneShowPointTitleLeg"").prop(""checked"", chart.sZone().showPointTitleLeg());
      $(""#sZoneShowPointTitleLeg"").change(function(){ chart.sZone().showPointTitleLeg(this.checked) });

      //drawChart();

    });
  </script>
</head>
<body>

  <div class=""chart"">

    <svg id=""svg1"" width=""100%"" height=""250"" <!--viewBox=""0 0 400 300""--> xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
      <defs>
        <marker id=""markerLegStart"" markerWidth=""8"" markerHeight=""8"" refx=""5"" refy=""5"">
            <circle cx=""5"" cy=""5"" r=""2"" style=""stroke: none; fill:#808090;""/>
        </marker>

        <marker id=""markerLegEnd"" markerWidth=""8"" markerHeight=""8"" refx=""5"" refy=""5"">
            <circle cx=""5"" cy=""5"" r=""3"" style=""stroke: none; fill:#808090;""/>
        </marker>
      </defs>
    </svg>

    <svg id=""svg2"" width=""70%"" height=""250"" <!--viewBox=""0 0 400 300""--> xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"">
      <defs>
        <marker id=""marker1"" markerWidth=""8"" markerHeight=""8"" refx=""5"" refy=""5"">
            <circle cx=""5"" cy=""5"" r=""2"" style=""stroke: none; fill:#808090;""/>
        </marker>

        <marker id=""marker2"" markerWidth=""8"" markerHeight=""8"" refx=""5"" refy=""5"">
            <circle cx=""5"" cy=""5"" r=""3"" style=""stroke: none; fill:#808090;""/>
        </marker>
      </defs>
    </svg>

  </div>

  <div class=""manage"">

    <div>
      <button id=""btnDraw"">Draw</button>
      <button id=""btnStart"">Start</button>
      <button id=""btnStop"">Stop</button>
    </div>

    <fieldset>
      <legend>XZone</legend>
      <label for=""xAxisIsBottom"">isBottom</label>
      <input type=""checkbox"" id=""xAxisIsBottom"">
    </fieldset> 

    <fieldset>
      <legend>SZone</legend>
      <label for=""sZoneShowRuler"">Ruler</label>
      <input type=""checkbox"" id=""sZoneShowRuler"">
    </fieldset> 

    <fieldset>
      <legend>Series Zone</legend>
      <p>
        <label for=""sZoneChartType"">Chart Type</label>
        <input type=""checkbox"" id=""chkChartTypePoint"" value=""POINT"">P
        <input type=""checkbox"" id=""chkChartTypeLine"" value=""LINE"">L
        <input type=""checkbox"" id=""chkChartTypeSpline"" value=""SPLINE"">S
        <input type=""checkbox"" id=""chkChartTypeLineSquare"" value=""LINE_SQUARE"">LS
        <input type=""checkbox"" id=""chkChartTypeSplineSquare"" value=""SPLINE_SQUARE"">SS
        <input type=""checkbox"" id=""chkChartTypeBar"" value=""BAR"">B
      </p>
      <p>
        <label for=""sZonePointType"">Point Chart Type</label>
        <input type=""radio"" name=""sZonePointType"" value=""NONE"">N
        <input type=""radio"" name=""sZonePointType"" value=""CIRCLE"">C
        <input type=""radio"" name=""sZonePointType"" value=""RECT"">R
        <input type=""radio"" name=""sZonePointType"" value=""TRI"">T
        <input type=""number"" id=""sZonePointSize"" step=""1"" min=""1"" max=""10"">
      </p>
      <p>
        <label for=""sZoneSquareFillType"">Square Fill Type</label>
        <input type=""radio"" name=""sZoneSquareFillType"" value=""TOP"">T
        <input type=""radio"" name=""sZoneSquareFillType"" value=""BOTTOM"">B
      </p>
      <p>
        <label for=""sZoneShowPointTooltip"">Point Tooltip</label>
        <input type=""checkbox"" id=""sZoneShowPointTooltip"">Show
        <input type=""text"" id=""sZonePointTooltipFormat"">
      </p>
      <p>
        <label for=""sZoneShowPointTitle"">Point Title</label>
        <input type=""checkbox"" id=""sZoneShowPointTitle"">Show
        <input type=""text"" id=""sZonePointTitleFormat"">
        <input type=""number"" id=""sZonePointTitleAngle"" step=""1"" min=""0"" max=""359"">
        <input type=""number"" id=""sZonePointTitleMargin"" step=""1"" min=""0"" max=""20"">
      </p>
      <p>
        <label for=""sZoneShowPointTitleLeg"">Point Title Leg</label>
        <input type=""checkbox"" id=""sZoneShowPointTitleLeg"">Show
      </p>
    </fieldset>

    <fieldset>
      <legend>Legend Zone</legend>
      <p><label for=""lZoneLegendMargin"">ZoneLegendMargin</label><input type=""number"" id=""lZoneLegendMargin"" /></p>
      <p><label for=""lZoneSeriesMargin"">ZoneSeriesMargin</label><input type=""number"" id=""lZoneSeriesMargin"" /></p>
      <p>
        <label for=""lZoneCorner"">Corner</label>
        <input type=""radio"" name=""lZoneCorner"" id=""lZoneCornerLEFTTOP"" value=""LEFTTOP"">LT
        <input type=""radio"" name=""lZoneCorner"" id=""lZoneCornerRIGHTTOP"" value=""RIGHTTOP"">RT
        <input type=""radio"" name=""lZoneCorner"" id=""lZoneCornerLEFTBOTTOM"" value=""LEFTBOTTOM"">LB
        <input type=""radio"" name=""lZoneCorner"" id=""lZoneCornerRIGHTBOTTOM"" value=""RIGHTBOTTOM"">RB
      </p>
    </fieldset>

  </div>

  <!--<div class=""chart"">
    <svg width=""500"" height=""500"">
      <defs>
        <marker id=""marker1"" markerWidth=""8"" markerHeight=""8"" refx=""5"" refy=""5"">
            <circle cx=""5"" cy=""5"" r=""3"" style=""stroke: none; fill:#000000;""/>
        </marker>

        <marker id=""marker2"" markerWidth=""13"" markerHeight=""13"" refx=""2"" refy=""6"" orient=""auto"">
            <path d=""M2,2 L2,11 L10,6 L2,2"" style=""fill: #000000;"" />
        </marker>
      </defs>
      <line x1=""100"" y1=""100"" x2=""200"" y2=""100"" style=""stroke: red; marker-end: url(#marker1); marker-start: url(#marker2)""></line>
    </svg>
  </div>-->

</body>
</html>"; 
     #endregion

 }//class
}//namespace
