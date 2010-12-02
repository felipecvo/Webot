namespace Webot.Tests {
    using System;
    using System.Collections.Generic;
    using System.Net;
    using NUnit.Framework;
    using FactoryRequest;

    [TestFixture()]
    public class WebFormTest {

        #region HTML Contents

        private const string GOOGLE_HOME_PAGE = @"<!doctype html><html><head><meta http-equiv=""content-type"" content=""text/html; charset=UTF-8""><title>Google</title><script>window.google={kEI:""ViPvTLOrD4eCetPHkfEK"",kEXPI:""25657,27816"",kCSI:{e:""25657,27816"",ei:""ViPvTLOrD4eCetPHkfEK"",expi:""25657,27816""},ml:function(){},pageState:""#"",kHL:""pt-BR"",time:function(){return(new Date).getTime()},log:function(b,d,
c){var a=new Image,e=google,g=e.lc,f=e.li;a.onerror=(a.onload=(a.onabort=function(){delete g[f]}));g[f]=a;c=c||""/gen_204?atyp=i&ct=""+b+""&cad=""+d+""&zx=""+google.time();a.src=c;e.li=f+1},lc:[],li:0,j:{en:1,l:function(){google.fl=true},e:function(){google.fl=true},b:location.hash&&location.hash!=""#"",bv:3,pl:[],mc:0,sc:0.5},Toolbelt:{}};(function(){for(var d=0,c;c=[""ad"",""bc"",""p"",""pa"",""zd"",""ac"",""pc"",""pah"",""ph"",""sa"",""spf"",""xx"",""zc"",""zz""][d++];)(function(a){google.j[a]=function(){google.j.pl.push([a,arguments])}})(c)})();
window.google.sn=""webhp"";var i=window.google.timers={};window.google.startTick=function(a,b){i[a]={t:{start:(new Date).getTime()},bfr:!(!b)}};window.google.tick=function(a,b,c){if(!i[a])google.startTick(a);i[a].t[b]=c||(new Date).getTime()};google.startTick(""load"",true);try{window.google.pt=window.gtbExternal&&window.gtbExternal.pageT();
}catch(v){}
window.google.jsrt_kill=1;
</script><style id=gstyle>body{margin:0}#gog{padding:3px 8px 0}td{line-height:.8em}.gac_m td{line-height:17px}form{margin-bottom:20px}body,td,a,p,.h{font-family:arial,sans-serif}.h{color:#36c}.q{color:#00c}.ts td{padding:0}.ts{border-collapse:collapse}em{font-weight:bold;font-style:normal}.lst{width:496px}.tiah{width:458px}input{font-family:inherit}a.gb1,a.gb2,a.gb3,a.gb4{color:#11c !important}#gog{background:#fff}#gbar,#guser{font-size:13px;padding-top:1px !important}#gbar{float:left;height:22px}#guser{padding-bottom:7px !important;text-align:right}.gbh,.gbd{border-top:1px solid #c9d7f1;font-size:1px}.gbh{height:0;position:absolute;top:24px;width:100%}#gbs,.gbm{background:#fff;left:0;position:absolute;text-align:left;visibility:hidden;z-index:1000}.gbm{border:1px solid;border-color:#c9d7f1 #36c #36c #a2bae7;z-index:1001}.gb1{margin-right:.5em}.gb1,.gb3{zoom:1}.gb2{display:block;padding:.2em .5em}.gb2,.gb3{text-decoration:none;border-bottom:none}a.gb1,a.gb2,a.gb3,a.gb4{color:#00c !important}a.gb2:hover{background:#36c;color:#fff !important}body{background:#fff;color:black}input{-moz-box-sizing:content-box}a{color:#11c;text-decoration:none}a:hover,a:active{text-decoration:underline}.fl a{color:#4272db}a:visited{color:#551a8b}a.gb1,a.gb4{text-decoration:underline}a.gb3:hover{text-decoration:none}#ghead a.gb2:hover{color:#fff!important}.ds{display:-moz-inline-box}.ds{border-bottom:solid 1px #e7e7e7;border-right:solid 1px #e7e7e7;display:inline-block;margin:3px 0 4px;margin-left:4px}.sblc{padding-top:5px}.sblc a{display:block;margin:2px 0;margin-left:13px;font-size:11px;}.lsbb{background:#eee;border:solid 1px;border-color:#ccc #999 #999 #ccc;height:30px;display:block}.lsb{background:url(/images/srpr/nav_logo27.png) bottom;font:15px arial,sans-serif;border:none;color:#000;cursor:pointer;height:30px;margin:0;outline:0;vertical-align:top}.lsb:active{background:#ccc}.lst:focus{outline:none}.ftl,#fll a{margin:0 12px}#addlang a{padding:0 3px}.gac_v div{display:none}.gac_v .gac_v2,.gac_bt{display:block!important}</style><script>var _gjwl=location;function _gjuc(){var b=_gjwl.href.indexOf(""#"");if(b>=0){var a=_gjwl.href.substring(b+1);if(/(^|&)q=/.test(a)&&a.indexOf(""#"")==-1&&!/(^|&)cad=h($|&)/.test(a)){_gjwl.replace(""/search?""+a.replace(/(^|&)fp=[^&]*/g,"""")+""&cad=h"");return 1}}return 0}function _gjp(){!(window._gjwl.hash&&window._gjuc())&&setTimeout(_gjp,500)};
google.y={};google.x=function(e,g){google.y[e.id]=[e,g];return false};window.rwt=function(a,f,g,k,l,h,c,m){try{if(a===window){a=window.event.srcElement;while(a){if(a.href)break;a=a.parentNode}}var b=encodeURIComponent||escape,d;d=a.getAttribute(""href"");if(c&&c.substring(0,6)!=""&sig2="")c=""&sig2=""+c;var n=[""/url?sa=t"","""",""&cd="",b(l),google.j&&google.j.pf?""&sqi=2"":"""",""&ved="",b(m),""&url="",
b(d).replace(/\+/g,""%2B""),""&ei="",""ViPvTLOrD4eCetPHkfEK"",h?""&usg=""+h:"""",c].join("""");a.href=n;a.onmousedown=""""}catch(o){}return true};
window.gbar={qs:function(){},tg:function(e){var o={id:'gbar'};for(i in e)o[i]=e[i];google.x(o,function(){gbar.tg(o)})}};</script></head><body bgcolor=#ffffff text=#000000 link=#0000cc vlink=#551a8b alink=#ff0000 onload=""try{!google.j.b&&document.f.q.focus()}catch(e){};if(document.images)new Image().src='/images/srpr/nav_logo27.png'"" ><textarea id=csi style=display:none></textarea><script>if(google.j.b)document.body.style.visibility='hidden';</script><iframe name=wgjf style=display:none src="""" onload=""google.j.l()"" onerror=""google.j.e()""></iframe><textarea id=wgjc style=display:none></textarea><textarea id=wwcache style=display:none></textarea><textarea id=csi style=display:none></textarea><textarea id=hcache style=display:none></textarea><span id=main><div id=ghead><div id=gog><div id=gbar><nobr><b class=gb1>Web</b> <a href=""http://www.google.com.br/imghp?hl=pt-br&tab=wi"" onclick=gbar.qs(this) class=gb1>Imagens</a> <a href=""http://video.google.com.br/?hl=pt-br&tab=wv"" onclick=gbar.qs(this) class=gb1>Vídeos</a> <a href=""http://maps.google.com.br/maps?hl=pt-br&tab=wl"" onclick=gbar.qs(this) class=gb1>Mapas</a> <a href=""http://news.google.com.br/nwshp?hl=pt-br&tab=wn"" onclick=gbar.qs(this) class=gb1>Notícias</a> <a href=""http://www.orkut.com/Home.aspx?hl=pt-br&tab=w0"" class=gb1>Orkut</a> <a href=""http://mail.google.com/mail/?hl=pt-br&tab=wm"" class=gb1>Gmail</a> <a href=""http://www.google.com.br/intl/pt-BR/options/"" onclick=""this.blur();gbar.tg(event);return !1"" aria-haspopup=true class=gb3><u>mais</u> <small>&#9660;</small></a><div class=gbm id=gbi><a href=""http://books.google.com.br/bkshp?hl=pt-br&tab=wp"" onclick=gbar.qs(this) class=gb2>Livros</a> <a href=""http://translate.google.com.br/?hl=pt-br&tab=wT"" onclick=gbar.qs(this) class=gb2>Tradutor</a> <a href=""http://blogsearch.google.com.br/?hl=pt-br&tab=wb"" onclick=gbar.qs(this) class=gb2>Blogs</a> <a href=""http://www.google.com.br/realtime?hl=pt-br&tab=wY"" onclick=gbar.qs(this) class=gb2>Atualizações</a> <div class=gb2><div class=gbd></div></div><a href=""http://www.youtube.com/?hl=pt-br&tab=w1&gl=BR"" onclick=gbar.qs(this) class=gb2>YouTube</a> <a href=""http://www.google.com/calendar/render?hl=pt-br&tab=wc"" class=gb2>Agenda</a> <a href=""http://picasaweb.google.com.br/home?hl=pt-br&tab=wq"" onclick=gbar.qs(this) class=gb2>Fotos</a> <a href=""http://docs.google.com/?hl=pt-br&tab=wo&authuser=0"" class=gb2>Docs</a> <a href=""http://www.google.com.br/reader/?hl=pt-br&tab=wy"" class=gb2>Reader</a> <a href=""http://sites.google.com/?hl=pt-br&tab=w3"" class=gb2>Sites</a> <a href=""http://groups.google.com.br/grphp?hl=pt-br&tab=wg"" onclick=gbar.qs(this) class=gb2>Grupos</a> <div class=gb2><div class=gbd></div></div><a href=""http://www.google.com.br/intl/pt-BR/options/"" class=gb2>e muito mais &raquo;</a> </div></nobr></div><div id=guser width=100%><nobr><span id=gbn class=gbi></span><span id=gbf class=gbf></span><b class=gb4>felipecvo@gmail.com</b> | <span id=gbe><a href=""/url?sa=p&pref=ig&pval=3&q=http://www.google.com.br/ig%3Fhl%3Dpt-BR%26source%3Diglk&usg=AFQjCNEufhwNAC9POZqcS5r7r07CUPbvAA"" class=gb4>iGoogle</a> | </span><a href=""/preferences?hl=pt-BR"" onclick=""this.blur();gbar.tg(event);return !1"" aria-haspopup=true aria-owns=gbg class=gb3><u>Configurações</u> <small>&#9660;</small></a> | <a href=""http://www.google.com.br/accounts/ClearSID?continue=http%3A%2F%2Fwww.google.com%2Faccounts%2FLogout%3Fcontinue%3Dhttp%3A%2F%2Fwww.google.com.br%2F"" class=gb4>Sair</a><div class=gbm id=gbg><a href=""/preferences?hl=pt-BR"" class=gb2>Configurações da pesquisa</a> <a href=""https://www.google.com/accounts/ManageAccount?hl=pt-br"" class=gb2>Configurações da Conta do Google</a> </div></nobr></div><div class=gbh style=left:0></div><div class=gbh style=right:0></div></div></div> <center><span id=body><center><br clear=all id=lgpd><div id=lga><div style=""padding:28px 0 3px""><div align=left style=""background:url(/intl/en_com/images/srpr/logo1w.png) no-repeat;height:110px;width:276px"" title=""Google"" id=logo onload=""window.lol&&lol()""><div nowrap style=""color:#777;font-size:16px;font-weight:bold;left:214px;position:relative;top:70px"">Brasil</div></div></div><br></div><form action=""/search"" name=f><table cellpadding=0 cellspacing=0><tr valign=top><td width=25%>&nbsp;</td><td align=center nowrap><input name=hl type=hidden value=pt-BR><input name=source type=hidden value=hp><input type=hidden name=biw><input type=hidden name=bih><div class=ds style=""height:32px;margin:4px 0""><div style=position:relative;zoom:1><input autocomplete=""off"" maxlength=2048 name=q class=""lst tiah"" title=""Pesquisa Google"" value="""" size=57 style=""background:#fff;border:1px solid #ccc;border-bottom-color:#999;border-right-color:#999;color:#000;font:18px arial,sans-serif bold;height:25px;margin:0;padding:5px 8px 0 6px;padding-right:38px;vertical-align:top""><img src=""/textinputassistant/tia.png"" width=27 height=23 alt="""" style=""position:absolute;cursor:pointer;right:5px;top:4px;z-index:300"" onclick=""var s=document.createElement('script');s.src='/textinputassistant/0/pt-BR_tia.js';google.append(s);""/></div></div><br style=""line-height:0""><span class=ds ><span class=lsbb><input name=btnG type=submit value=""Pesquisa Google"" class=lsb onclick=""this.checked=1""></span></span><span class=ds><span class=lsbb><input name=btnI type=submit value=""Estou com sorte"" class=lsb onclick=""this.checked=1""></span></span></td><td nowrap width=25% align=left class=sblc><a href=""/advanced_search?hl=pt-BR"">Pesquisa avançada</a><a href=""/language_tools?hl=pt-BR"">Ferramentas de idiomas</a></td></tr></table></form><div style=""font-size:83%;min-height:3.5em""><br></div><div id=res></div></center></span> <span id=footer><center id=fctr><div style=""font-size:10pt""><div id=fll style=""margin:19px auto 19px auto;text-align:center""><a href=""/intl/pt-BR/ads/"">Soluções de publicidade</a><a href=""/services/"">Soluções empresariais</a><a href=""/intl/pt-BR/about.html"">Sobre o Google</a><a href=""http://www.google.com/ncr"">Google.com in English</a></div></div><p style=""color:#767676;font-size:8pt"">&copy; 2010 - <a href=""/intl/pt-BR/privacy.html"">Privacidade</a></p></center></span> </span> <script>function _gjp() {!(location.hash && _gjuc()) && setTimeout(_gjp, 500);}google.j[1]={cc:[],co:['ghead','body','footer','xjsi'],pc:[],css:document.getElementById('gstyle').innerHTML,main:'<div id=ghead></div>' +'<span id=body></span>' +'<span id=footer></span>' +'<span id=xjsi></span>'};</script><script>function wgjp(){var xjs=document.createElement('script');xjs.src='/extern_chrome/45e6118c2d7b8c30.js';(document.getElementById('xjsd') || document.body).appendChild(xjs)};</script></center><div id=xjsd></div><div id=xjsi><script>if(google.y)google.y.first=[];google.dlj=function(b){window.setTimeout(function(){var a=document.createElement(""script"");a.src=b;document.getElementById(""xjsd"").appendChild(a)},0)};
if(google.y)google.y.first=[];if(!google.xjs){google.dstr=[];google.rein=[];if (google.timers && google.timers.load.t) {google.timers.load.t.xjsls=new Date().getTime();}google.dlj('/extern_js/f/CgVwdC1CUhICYnIrMEU4ACwrMFo4ACwrMA44ACwrMBc4ACwrMCc4ACwrMDw4ACwrMFE4ACwrMAo4AEAdLCswFjgALCswGTgALCswITgAQAEsKzAlOM-IASwrMCo4CywrMCs4ESwrMDU4ACwrMEA4ACwrMEE4ACwrME04ACwrME44ACwrMFM4ACwrMFQ4ACwrMF84ACwrMGk4ACwrMB04ACwrMBg4ACwrMCY4ACyAAiiQAiU/HU9cQAl0Zgg.js');google.xjs=1}google.neegg=1;google.mc = [];google.mc = google.mc.concat([[14,{}],[95,{""kfe"":{""kfeHost"":""clients1.google.com.br"",""kfeUrlPrefix"":""/webpagethumbnail?c=11\u0026r=2\u0026f=2\u0026s=300:585\u0026query=\u0026hl=pt\u0026gl=br"",""maxPrefetchConnections"":2,""prefetch"":90,""slowConnection"":false},""logging"":{""csiFraction"":0.05,""gen204Fraction"":0.05},""msgs"":{""noPreview"":""Visualização indisponível""},""pb"":{""desiredHeight"":585,""desiredWidth"":300,""minHeight"":200,""minWidth"":300},""time"":{""loading"":100,""timeout"":2500}}],[64,{}],[105,{}],[22,{""m_error"":""\u003Cfont color=red\u003EErro:\u003C/font\u003E O servidor não pôde concluir sua solicitação.  Tente novamente daqui a 30 segundos."",""m_tip"":""Clique para obter mais informações.""}],[84,{}],[29,{}]]);google.y.first.push(function(){var form=document.f||document.f||document.gs;google.ac.i(form,form.q,'','','',{o:1,sw:1});(function(){
function e(){var a=null;if(window.ActiveXObject){a=new ActiveXObject(""Msxml2.XMLHTTP"");if(!a)a=new ActiveXObject(""Microsoft.XMLHTTP"")}else if(window.XMLHttpRequest)a=new XMLHttpRequest;return a}function f(a){if(window.execScript)window.execScript(a,""JavaScript"");else if(window.eval){var b=null;window.eval(""var _et_ = 1;"");if(typeof window._et_!=""undefined""){delete window._et_;b=true}else b=false;if(b)window.eval(a);else{var d=window.document,c=d.createElement(""script"");c.type=""text/javascript"";c.defer=
false;c.appendChild(d.createTextNode(a));d.body.appendChild(c);d.body.removeChild(c)}}}function g(a){var b=a;if(b&&b.length>0&&b.substring(0,5)==""throw"")b=b.substring(27);f(b)}function h(a){if(a.readyState==4&&(a.status==200||a.status==304))try{g(a.responseText)}catch(b){}}function i(){if(window.google&&!window.google.cp){window.google.cp={};window.google.cp.o={l:""/intl/en_com/images/srpr/logo1w.png"",h:false,a:""Google"",u:"""",d:false};
var a=e();if(a){a.open(""GET"",""/ig/cp/get?hl=pt-BR&gl=br"",true);a.onreadystatechange=function(){h(a)};a.send(null)}}}i();
})();
;google.med&&google.med('init');google.History&&google.History.initialize('/')});if(google.j&&google.j.en&&google.j.xi){window.setTimeout(google.j.xi,0);google.fade=null;}</script></div><script>(function(){
var b,d,e,f;function g(a,c){if(a.removeEventListener){a.removeEventListener(""load"",c,false);a.removeEventListener(""error"",c,false)}else{a.detachEvent(""onload"",c);a.detachEvent(""onerror"",c)}}function h(a){f=(new Date).getTime();++d;a=a||window.event;var c=a.target||a.srcElement;g(c,h)}var i=document.getElementsByTagName(""img"");b=i.length;d=0;for(var j=0,k;j<b;++j){k=i[j];if(k.complete||typeof k.src!=""string""||!k.src)++d;else if(k.addEventListener){k.addEventListener(""load"",h,false);k.addEventListener(""error"",
h,false)}else{k.attachEvent(""onload"",h);k.attachEvent(""onerror"",h)}}e=b-d;function l(){if(!google.timers.load.t)return;google.timers.load.t.ol=(new Date).getTime();google.timers.load.t.iml=f;google.kCSI.imc=d;google.kCSI.imn=b;google.kCSI.imp=e;google.timers.load.t.xjs&&google.report&&google.report(google.timers.load,google.kCSI)}if(window.addEventListener)window.addEventListener(""load"",l,false);else if(window.attachEvent)window.attachEvent(""onload"",l);google.timers.load.t.prt=(f=(new Date).getTime());
})();

</script>";

        #endregion

        [Test()]
        public void RequestReturnsHtmlWithNoForm() {
            string url = "http://www.noform.com/justtext.html";

            Factory.Register(url, "<html>no form</form>");

            var form = WebForm.Get(url);

            Assert.IsNull(form);
        }

        [Test]
        public void RequestReturnContentWithForm() {
            var url = "http://www.google.com/";
            Factory.Register(url, GOOGLE_HOME_PAGE);

            var form = WebForm.Get(url);
            AssertGoogleForm(form, true);
        }

        [Test]
        public void ConstructWebFormFromString() {
            var form = WebForm.Build(GOOGLE_HOME_PAGE);
            AssertGoogleForm(form, false);
        }

        [Test]
        public void ShouldNotConstructWebFormFromString() {
            var form = WebForm.Build("<html>no form.</html>");
            Assert.IsNull(form);
        }

        [Test]
        public void ShouldSubmitWebForm() {
            var url = "http://mysite.com/webform.aspx";
            var expected = "success";
            Factory.Register(url, expected);
            var fields = new Dictionary<string, string>();
            var form = new WebForm { Action = url, Method = "POST", Fields = fields, Cookies = new CookieCollection() };

            var response = form.Submit();
            
            Assert.IsNotNull(response);
            Assert.AreEqual(expected, response);
        }

        [Test]
        public void ShouldProcessMultipleFieldsWithSameName() {
            var form = WebForm.Build("<form><input name=\"field1\" value=\"1\" /><input name=\"field1\" value=\"2\" /></form>");
            Assert.IsNotNull(form);
            Assert.AreEqual(1, form.Fields.Count);
            Assert.AreEqual("2", form.Fields["field1"]);
        }

        [Test]
        public void ShouldGetSuccessfulyFromFacebook() {
            var form = WebForm.Get("https://graph.facebook.com/oauth/authorize?client_id=161520467221210&redirect_uri=http://www.facebook.com/connect/login_success.html&type=user_agent&display=popup");

            Assert.IsNotNull(form);
            Assert.AreEqual("https://login.facebook.com/login.php?login_attempt=1&popup=1&fbconnect=1&display=popup&next=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Fuiserver.php%3Fmethod%3Dpermissions.request%26app_id%3D161520467221210%26display%3Dpopup%26redirect_uri%3Dhttp%253A%252F%252Fwww.facebook.com%252Fconnect%252Flogin_success.html%26type%3Duser_agent%26fbconnect%3D1%26%252Aapp_id%252A%3D161520467221210%26from_login%3D1&legacy_return=1", form.Action);
        }

        // TODO: test all properties that would be loaded from html

        // TODO: test post to relative url...

        private void AssertGoogleForm(WebForm form, bool absolute) {
            Assert.IsNotNull(form);
            if(absolute) {
                Assert.AreEqual("http://www.google.com/search", form.Action);
            } else {
                Assert.AreEqual("/search", form.Action);
            }
            Assert.AreEqual("GET", form.Method);
            Assert.AreEqual(7, form.Fields.Count);
            Assert.AreEqual("pt-BR", form.Fields["hl"]);
            Assert.IsNullOrEmpty(form.Id);
            Assert.IsNull(form.Id);
            Assert.AreEqual("f", form.Name);
            Assert.IsNullOrEmpty(form.EncType);
        }
    }
}
