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
window.gbar={qs:function(){},tg:function(e){var o={id:'gbar'};for(i in e)o[i]=e[i];google.x(o,function(){gbar.tg(o)})}};</script></head><body bgcolor=#ffffff text=#000000 link=#0000cc vlink=#551a8b alink=#ff0000 onload=""try{!google.j.b&&document.f.q.focus()}catch(e){};if(document.images)new Image().src='/images/srpr/nav_logo27.png'"" ><textarea id=csi style=display:none></textarea><script>if(google.j.b)document.body.style.visibility='hidden';</script><iframe name=wgjf style=display:none src="""" onload=""google.j.l()"" onerror=""google.j.e()""></iframe><textarea id=wgjc style=display:none></textarea><textarea id=wwcache style=display:none></textarea><textarea id=csi style=display:none></textarea><textarea id=hcache style=display:none></textarea><span id=main><div id=ghead><div id=gog><div id=gbar><nobr><b class=gb1>Web</b> <a href=""http://www.google.com.br/imghp?hl=pt-br&tab=wi"" onclick=gbar.qs(this) class=gb1>Imagens</a> <a href=""http://video.google.com.br/?hl=pt-br&tab=wv"" onclick=gbar.qs(this) class=gb1>Vídeos</a> <a href=""http://maps.google.com.br/maps?hl=pt-br&tab=wl"" onclick=gbar.qs(this) class=gb1>Mapas</a> <a href=""http://news.google.com.br/nwshp?hl=pt-br&tab=wn"" onclick=gbar.qs(this) class=gb1>Notícias</a> <a href=""http://www.orkut.com/Home.aspx?hl=pt-br&tab=w0"" class=gb1>Orkut</a> <a href=""http://mail.google.com/mail/?hl=pt-br&tab=wm"" class=gb1>Gmail</a> <a href=""http://www.google.com.br/intl/pt-BR/options/"" onclick=""this.blur();gbar.tg(event);return !1"" aria-haspopup=true class=gb3><u>mais</u> <small>&#9660;</small></a><div class=gbm id=gbi><a href=""http://books.google.com.br/bkshp?hl=pt-br&tab=wp"" onclick=gbar.qs(this) class=gb2>Livros</a> <a href=""http://translate.google.com.br/?hl=pt-br&tab=wT"" onclick=gbar.qs(this) class=gb2>Tradutor</a> <a href=""http://blogsearch.google.com.br/?hl=pt-br&tab=wb"" onclick=gbar.qs(this) class=gb2>Blogs</a> <a href=""http://www.google.com.br/realtime?hl=pt-br&tab=wY"" onclick=gbar.qs(this) class=gb2>Atualizações</a> <div class=gb2><div class=gbd></div></div><a href=""http://www.youtube.com/?hl=pt-br&tab=w1&gl=BR"" onclick=gbar.qs(this) class=gb2>YouTube</a> <a href=""http://www.google.com/calendar/render?hl=pt-br&tab=wc"" class=gb2>Agenda</a> <a href=""http://picasaweb.google.com.br/home?hl=pt-br&tab=wq"" onclick=gbar.qs(this) class=gb2>Fotos</a> <a href=""http://docs.google.com/?hl=pt-br&tab=wo&authuser=0"" class=gb2>Docs</a> <a href=""http://www.google.com.br/reader/?hl=pt-br&tab=wy"" class=gb2>Reader</a> <a href=""http://sites.google.com/?hl=pt-br&tab=w3"" class=gb2>Sites</a> <a href=""http://groups.google.com.br/grphp?hl=pt-br&tab=wg"" onclick=gbar.qs(this) class=gb2>Grupos</a> <div class=gb2><div class=gbd></div></div><a href=""http://www.google.com.br/intl/pt-BR/options/"" class=gb2>e muito mais &raquo;</a> </div></nobr></div><div id=guser width=100%><nobr><span id=gbn class=gbi></span><span id=gbf class=gbf></span><b class=gb4>user@gmail.com</b> | <span id=gbe><a href=""/url?sa=p&pref=ig&pval=3&q=http://www.google.com.br/ig%3Fhl%3Dpt-BR%26source%3Diglk&usg=AFQjCNEufhwNAC9POZqcS5r7r07CUPbvAA"" class=gb4>iGoogle</a> | </span><a href=""/preferences?hl=pt-BR"" onclick=""this.blur();gbar.tg(event);return !1"" aria-haspopup=true aria-owns=gbg class=gb3><u>Configurações</u> <small>&#9660;</small></a> | <a href=""http://www.google.com.br/accounts/ClearSID?continue=http%3A%2F%2Fwww.google.com%2Faccounts%2FLogout%3Fcontinue%3Dhttp%3A%2F%2Fwww.google.com.br%2F"" class=gb4>Sair</a><div class=gbm id=gbg><a href=""/preferences?hl=pt-BR"" class=gb2>Configurações da pesquisa</a> <a href=""https://www.google.com/accounts/ManageAccount?hl=pt-br"" class=gb2>Configurações da Conta do Google</a> </div></nobr></div><div class=gbh style=left:0></div><div class=gbh style=right:0></div></div></div> <center><span id=body><center><br clear=all id=lgpd><div id=lga><div style=""padding:28px 0 3px""><div align=left style=""background:url(/intl/en_com/images/srpr/logo1w.png) no-repeat;height:110px;width:276px"" title=""Google"" id=logo onload=""window.lol&&lol()""><div nowrap style=""color:#777;font-size:16px;font-weight:bold;left:214px;position:relative;top:70px"">Brasil</div></div></div><br></div><form action=""/search"" name=f><table cellpadding=0 cellspacing=0><tr valign=top><td width=25%>&nbsp;</td><td align=center nowrap><input name=hl type=hidden value=pt-BR><input name=source type=hidden value=hp><input type=hidden name=biw><input type=hidden name=bih><div class=ds style=""height:32px;margin:4px 0""><div style=position:relative;zoom:1><input autocomplete=""off"" maxlength=2048 name=q class=""lst tiah"" title=""Pesquisa Google"" value="""" size=57 style=""background:#fff;border:1px solid #ccc;border-bottom-color:#999;border-right-color:#999;color:#000;font:18px arial,sans-serif bold;height:25px;margin:0;padding:5px 8px 0 6px;padding-right:38px;vertical-align:top""><img src=""/textinputassistant/tia.png"" width=27 height=23 alt="""" style=""position:absolute;cursor:pointer;right:5px;top:4px;z-index:300"" onclick=""var s=document.createElement('script');s.src='/textinputassistant/0/pt-BR_tia.js';google.append(s);""/></div></div><br style=""line-height:0""><span class=ds ><span class=lsbb><input name=btnG type=submit value=""Pesquisa Google"" class=lsb onclick=""this.checked=1""></span></span><span class=ds><span class=lsbb><input name=btnI type=submit value=""Estou com sorte"" class=lsb onclick=""this.checked=1""></span></span></td><td nowrap width=25% align=left class=sblc><a href=""/advanced_search?hl=pt-BR"">Pesquisa avançada</a><a href=""/language_tools?hl=pt-BR"">Ferramentas de idiomas</a></td></tr></table></form><div style=""font-size:83%;min-height:3.5em""><br></div><div id=res></div></center></span> <span id=footer><center id=fctr><div style=""font-size:10pt""><div id=fll style=""margin:19px auto 19px auto;text-align:center""><a href=""/intl/pt-BR/ads/"">Soluções de publicidade</a><a href=""/services/"">Soluções empresariais</a><a href=""/intl/pt-BR/about.html"">Sobre o Google</a><a href=""http://www.google.com/ncr"">Google.com in English</a></div></div><p style=""color:#767676;font-size:8pt"">&copy; 2010 - <a href=""/intl/pt-BR/privacy.html"">Privacidade</a></p></center></span> </span> <script>function _gjp() {!(location.hash && _gjuc()) && setTimeout(_gjp, 500);}google.j[1]={cc:[],co:['ghead','body','footer','xjsi'],pc:[],css:document.getElementById('gstyle').innerHTML,main:'<div id=ghead></div>' +'<span id=body></span>' +'<span id=footer></span>' +'<span id=xjsi></span>'};</script><script>function wgjp(){var xjs=document.createElement('script');xjs.src='/extern_chrome/45e6118c2d7b8c30.js';(document.getElementById('xjsd') || document.body).appendChild(xjs)};</script></center><div id=xjsd></div><div id=xjsi><script>if(google.y)google.y.first=[];google.dlj=function(b){window.setTimeout(function(){var a=document.createElement(""script"");a.src=b;document.getElementById(""xjsd"").appendChild(a)},0)};
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

        private const string FACEBOOK_LOGIN_PAGE = @"
<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Strict//EN""
   ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd""> 
<html xmlns=""http://www.w3.org/1999/xhtml"" xml:lang=""en"" lang=""en"" id=""facebook"" class="" no_js""> 
<head> 
<meta http-equiv=""Content-type"" content=""text/html; charset=utf-8"" /> 
<meta http-equiv=""Content-language"" content=""en"" /> 
<script type=""text/javascript""> 
//<![CDATA[
CavalryLogger=false;window._is_quickling_index="""";window._EagleEyeSeed=""DUzM"";
//]]>
<<<<<<< Updated upstream
</script><noscript> <meta http-equiv=refresh content=""0; URL=/login.php?api_key=1234567890&amp;skip_api_login=1&amp;display=popup&amp;cancel_url=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Flogin_success.html%3Ferror_reason%3Duser_denied%26error%3Daccess_denied%26error_description%3DThe%2Buser%2Bdenied%2Byour%2Brequest.&amp;fbconnect=1&amp;next=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Fuiserver.php%3Fmethod%3Dpermissions.request%26app_id%3D1234567890%26display%3Dpopup%26redirect_uri%3Dhttp%253A%252F%252Fwww.facebook.com%252Fconnect%252Flogin_success.html%26type%3Duser_agent%26fbconnect%3D1%26%252Aapp_id%252A%3D1234567890%26from_login%3D1&amp;_fb_noscript=1"" /> </noscript> 
 
<meta name=""robots"" content=""noodp,noydir,noindex,nofollow,noarchive,nosnippet"" /> 
<meta name=""description"" content="" Facebook is a social utility that connects people with friends and others who work, study and live around them. People use Facebook to keep up with friends, upload an unlimited number of photos, post links and videos, and learn more about the people they meet."" /> 
<link rel=""alternate"" media=""handheld"" href=""https://ssl.facebook.com/login.php?api_key=1234567890&amp;skip_api_login=1&amp;display=popup&amp;cancel_url=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Flogin_success.html%3Ferror_reason%3Duser_denied%26error%3Daccess_denied%26error_description%3DThe%2Buser%2Bdenied%2Byour%2Brequest.&amp;fbconnect=1&amp;next=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Fuiserver.php%3Fmethod%3Dpermissions.request%26app_id%3D1234567890%26display%3Dpopup%26redirect_uri%3Dhttp%253A%252F%252Fwww.facebook.com%252Fconnect%252Flogin_success.html%26type%3Duser_agent%26fbconnect%3D1%26%252Aapp_id%252A%3D1234567890%26from_login%3D1"" /> 
=======
</script><noscript> <meta http-equiv=refresh content=""0; URL=/login.php?api_key=161520467221210&amp;skip_api_login=1&amp;display=popup&amp;cancel_url=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Flogin_success.html%3Ferror_reason%3Duser_denied%26error%3Daccess_denied%26error_description%3DThe%2Buser%2Bdenied%2Byour%2Brequest.&amp;fbconnect=1&amp;next=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Fuiserver.php%3Fmethod%3Dpermissions.request%26app_id%3D161520467221210%26display%3Dpopup%26redirect_uri%3Dhttp%253A%252F%252Fwww.facebook.com%252Fconnect%252Flogin_success.html%26type%3Duser_agent%26fbconnect%3D1%26%252Aapp_id%252A%3D161520467221210%26from_login%3D1&amp;_fb_noscript=1"" /> </noscript> 
 
<meta name=""robots"" content=""noodp,noydir,noindex,nofollow,noarchive,nosnippet"" /> 
<meta name=""description"" content="" Facebook is a social utility that connects people with friends and others who work, study and live around them. People use Facebook to keep up with friends, upload an unlimited number of photos, post links and videos, and learn more about the people they meet."" /> 
<link rel=""alternate"" media=""handheld"" href=""https://ssl.facebook.com/login.php?api_key=161520467221210&amp;skip_api_login=1&amp;display=popup&amp;cancel_url=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Flogin_success.html%3Ferror_reason%3Duser_denied%26error%3Daccess_denied%26error_description%3DThe%2Buser%2Bdenied%2Byour%2Brequest.&amp;fbconnect=1&amp;next=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Fuiserver.php%3Fmethod%3Dpermissions.request%26app_id%3D161520467221210%26display%3Dpopup%26redirect_uri%3Dhttp%253A%252F%252Fwww.facebook.com%252Fconnect%252Flogin_success.html%26type%3Duser_agent%26fbconnect%3D1%26%252Aapp_id%252A%3D161520467221210%26from_login%3D1"" /> 
>>>>>>> Stashed changes
<title>Login | Facebook</title> 
<noscript><meta http-equiv=""X-Frame-Options"" content=""deny"" /></noscript> 
    <link type=""text/css"" rel=""stylesheet"" href=""https://s-static.ak.facebook.com/rsrc.php/zo/r/m3Tla9bbrIo.css"" /> 
    <link type=""text/css"" rel=""stylesheet"" href=""https://s-static.ak.facebook.com/rsrc.php/zx/r/ac7q0b7pX55.css"" /> 
    <link type=""text/css"" rel=""stylesheet"" href=""https://s-static.ak.facebook.com/rsrc.php/zZ/r/C4rLJTlB3Nb.css"" /> 
    <link type=""text/css"" rel=""stylesheet"" href=""https://s-static.ak.facebook.com/rsrc.php/z2/r/yyvIue42m_y.css"" /> 
    <link type=""text/css"" rel=""stylesheet"" href=""https://s-static.ak.facebook.com/rsrc.php/zZ/r/1x2cFH1serd.css"" /> 
 
    <script type=""text/javascript"" src=""https://s-static.ak.facebook.com/rsrc.php/zQ/r/IUPuxNuZZDM.js""></script> 
 
<link rel=""search"" type=""application/opensearchdescription+xml"" href=""https://s-static.ak.facebook.com/rsrc.php/zJ/r/H2SSvhJMJA-.xml"" title=""Facebook"" /> 
<link rel=""shortcut icon"" href=""https://s-static.ak.facebook.com/rsrc.php/z7/r/5875srnzL-I.ico"" /></head> 
<body class=""login_page UIPage_LoggedOut Locale_en_US""> 
<div id=""booklet""><div id=""pageheader""><h1 id=""homelink"">Facebook Login</h1></div> 
<<<<<<< Updated upstream
<div class=""confirmation_stripes""></div><div id=""content"" class=""fb_content clearfix""><div class=""login_form_container""><form method=""POST"" action=""https://login.facebook.com/login.php?login_attempt=1&amp;popup=1&amp;fbconnect=1&amp;display=popup&amp;next=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Fuiserver.php%3Fmethod%3Dpermissions.request%26app_id%3D1234567890%26display%3Dpopup%26redirect_uri%3Dhttp%253A%252F%252Fwww.facebook.com%252Fconnect%252Flogin_success.html%26type%3Duser_agent%26fbconnect%3D1%26%252Aapp_id%252A%3D1234567890%26from_login%3D1&amp;legacy_return=1"" id=""login_form"" onsubmit=""return Event.__inlineSubmit(this,event)""><input type=""hidden"" name=""charset_test"" value=""&euro;,&acute;,€,´,水,Д,Є"" /><input type=""hidden"" name=""lsd"" value=""ybb5p"" autocomplete=""off"" />Log in to use your Facebook account with <a href=""http://www.facebook.com/apps/application.php?id=1234567890"" target=""_blank"">SocialMan</a>.<div id=""loginform"" style=""""><input type=""hidden"" id=""next"" name=""next"" value=""http://www.facebook.com/connect/uiserver.php?method=permissions.request&amp;app_id=1234567890&amp;display=popup&amp;redirect_uri=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Flogin_success.html&amp;type=user_agent&amp;fbconnect=1&amp;%2Aapp_id%2A=1234567890&amp;from_login=1"" autocomplete=""off"" /><input type=""hidden"" id=""api_key"" name=""api_key"" value=""1234567890"" autocomplete=""off"" /><input type=""hidden"" id=""return_session"" name=""return_session"" value=""0"" autocomplete=""off"" /><input type=""hidden"" id=""cancel_url"" name=""cancel_url"" value=""http://www.facebook.com/connect/login_success.html?error_reason=user_denied&amp;error=access_denied&amp;error_description=The+user+denied+your+request."" autocomplete=""off"" /><input type=""hidden"" id=""legacy_return"" name=""legacy_return"" value=""1"" autocomplete=""off"" /><input type=""hidden"" id=""display"" name=""display"" value=""popup"" autocomplete=""off"" /><input type=""hidden"" id=""session_key_only"" name=""session_key_only"" value=""0"" autocomplete=""off"" /><input type=""hidden"" id=""skip_api_login"" name=""skip_api_login"" value=""1"" autocomplete=""off"" /><input type=""hidden"" id=""trynum"" name=""trynum"" value=""1"" autocomplete=""off"" /><input type=""hidden"" name=""charset_test"" value=""&euro;,&acute;,€,´,水,Д,Є"" /><input type=""hidden"" id=""lsd"" name=""lsd"" value=""ybb5p"" autocomplete=""off"" /><div class=""form_row clearfix ""><label for=""email"" id=""label_email"" class=""login_form_label"">Email:</label><input type=""text"" class=""inputtext"" id=""email"" name=""email"" value="""" onkeypress=""formchange()"" /></div><div class=""form_row clearfix ""><label for=""pass"" id=""label_pass"" class=""login_form_label"">Password:</label><input type=""password"" class=""inputpassword"" id=""pass"" name=""pass"" value="""" /></div><label class=""persistent""><input type=""checkbox"" class=""inputcheckbox "" checked=""checked"" id=""persistent_inputcheckbox"" name=""persistent"" value=""1"" /><span id=""persistent_login_text"">Keep me logged in</span></label><input type=""hidden"" id=""default_persistent"" name=""default_persistent"" value=""1"" autocomplete=""off"" /><p class=""reset_password form_row""><a href=""http://www.facebook.com/reset.php?locale=en_US"" target=""_blank"" tabindex=""-1"">Forgot your password?</a></p></div><div id=""dialog_buttons"" class=""dialog_buttons"" style=""""><div class=""register_link""><a href=""http://www.facebook.com/r.php?possible_fb_user=1&amp;fbconnect=1&amp;api_key=1234567890&amp;app_id=1234567890&amp;cancel_url=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Flogin_success.html%3Ferror_reason%3Duser_denied%26error%3Daccess_denied%26error_description%3DThe%2Buser%2Bdenied%2Byour%2Brequest.&amp;is_enabled=1&amp;popup=1&amp;locale=en_US"" target=""_blank"" rel=""nofollow"" id=""reg_btn_link"" tabindex=""-1"">Sign up for Facebook</a></div><label class=""uiButton uiButtonConfirm uiButtonLarge""><input value=""Login"" name=""login"" onclick="""" type=""submit"" /></label><label class=""uiButton uiButtonLarge""><input value=""Cancel"" name=""cancel"" type=""button"" onclick=""goURI(&quot;http:\/\/www.facebook.com\/connect\/login_success.html?error_reason=user_denied&amp;error=access_denied&amp;error_description=The+user+denied+your+request.&quot;.replace(&quot;%22xxRESULTTOKENxx%22&quot;,
=======
<div class=""confirmation_stripes""></div><div id=""content"" class=""fb_content clearfix""><div class=""login_form_container""><form method=""POST"" action=""https://login.facebook.com/login.php?login_attempt=1&amp;popup=1&amp;fbconnect=1&amp;display=popup&amp;next=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Fuiserver.php%3Fmethod%3Dpermissions.request%26app_id%3D161520467221210%26display%3Dpopup%26redirect_uri%3Dhttp%253A%252F%252Fwww.facebook.com%252Fconnect%252Flogin_success.html%26type%3Duser_agent%26fbconnect%3D1%26%252Aapp_id%252A%3D161520467221210%26from_login%3D1&amp;legacy_return=1"" id=""login_form"" onsubmit=""return Event.__inlineSubmit(this,event)""><input type=""hidden"" name=""charset_test"" value=""&euro;,&acute;,€,´,水,Д,Є"" /><input type=""hidden"" name=""lsd"" value=""ybb5p"" autocomplete=""off"" />Log in to use your Facebook account with <a href=""http://www.facebook.com/apps/application.php?id=161520467221210"" target=""_blank"">SocialMan</a>.<div id=""loginform"" style=""""><input type=""hidden"" id=""next"" name=""next"" value=""http://www.facebook.com/connect/uiserver.php?method=permissions.request&amp;app_id=161520467221210&amp;display=popup&amp;redirect_uri=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Flogin_success.html&amp;type=user_agent&amp;fbconnect=1&amp;%2Aapp_id%2A=161520467221210&amp;from_login=1"" autocomplete=""off"" /><input type=""hidden"" id=""api_key"" name=""api_key"" value=""161520467221210"" autocomplete=""off"" /><input type=""hidden"" id=""return_session"" name=""return_session"" value=""0"" autocomplete=""off"" /><input type=""hidden"" id=""cancel_url"" name=""cancel_url"" value=""http://www.facebook.com/connect/login_success.html?error_reason=user_denied&amp;error=access_denied&amp;error_description=The+user+denied+your+request."" autocomplete=""off"" /><input type=""hidden"" id=""legacy_return"" name=""legacy_return"" value=""1"" autocomplete=""off"" /><input type=""hidden"" id=""display"" name=""display"" value=""popup"" autocomplete=""off"" /><input type=""hidden"" id=""session_key_only"" name=""session_key_only"" value=""0"" autocomplete=""off"" /><input type=""hidden"" id=""skip_api_login"" name=""skip_api_login"" value=""1"" autocomplete=""off"" /><input type=""hidden"" id=""trynum"" name=""trynum"" value=""1"" autocomplete=""off"" /><input type=""hidden"" name=""charset_test"" value=""&euro;,&acute;,€,´,水,Д,Є"" /><input type=""hidden"" id=""lsd"" name=""lsd"" value=""ybb5p"" autocomplete=""off"" /><div class=""form_row clearfix ""><label for=""email"" id=""label_email"" class=""login_form_label"">Email:</label><input type=""text"" class=""inputtext"" id=""email"" name=""email"" value="""" onkeypress=""formchange()"" /></div><div class=""form_row clearfix ""><label for=""pass"" id=""label_pass"" class=""login_form_label"">Password:</label><input type=""password"" class=""inputpassword"" id=""pass"" name=""pass"" value="""" /></div><label class=""persistent""><input type=""checkbox"" class=""inputcheckbox "" checked=""checked"" id=""persistent_inputcheckbox"" name=""persistent"" value=""1"" /><span id=""persistent_login_text"">Keep me logged in</span></label><input type=""hidden"" id=""default_persistent"" name=""default_persistent"" value=""1"" autocomplete=""off"" /><p class=""reset_password form_row""><a href=""http://www.facebook.com/reset.php?locale=en_US"" target=""_blank"" tabindex=""-1"">Forgot your password?</a></p></div><div id=""dialog_buttons"" class=""dialog_buttons"" style=""""><div class=""register_link""><a href=""http://www.facebook.com/r.php?possible_fb_user=1&amp;fbconnect=1&amp;api_key=161520467221210&amp;app_id=161520467221210&amp;cancel_url=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Flogin_success.html%3Ferror_reason%3Duser_denied%26error%3Daccess_denied%26error_description%3DThe%2Buser%2Bdenied%2Byour%2Brequest.&amp;is_enabled=1&amp;popup=1&amp;locale=en_US"" target=""_blank"" rel=""nofollow"" id=""reg_btn_link"" tabindex=""-1"">Sign up for Facebook</a></div><label class=""uiButton uiButtonConfirm uiButtonLarge""><input value=""Login"" name=""login"" onclick="""" type=""submit"" /></label><label class=""uiButton uiButtonLarge""><input value=""Cancel"" name=""cancel"" type=""button"" onclick=""goURI(&quot;http:\/\/www.facebook.com\/connect\/login_success.html?error_reason=user_denied&amp;error=access_denied&amp;error_description=The+user+denied+your+request.&quot;.replace(&quot;%22xxRESULTTOKENxx%22&quot;,
>>>>>>> Stashed changes
                                     encodeURIComponent(JSON.encode(null))));"" /></label></div></form> 
</div></div></div><script type=""text/javascript"">/* <![CDATA[ */if (top != self) { try { if (parent != top) { throw 1; } var disallowed = [""apps.facebook.com"",""\/pages\/""]; href = top.location.href.toLowerCase(); for (var i = 0; i < disallowed.length; i++) { if (href.indexOf(disallowed[i]) >= 0) { throw 1; } } } catch (e) {setTimeout(function() {var fb_cj_img = new Image(); fb_cj_img.src = ""http:\/\/error.facebook.com\/common\/scribe_endpoint.php?c=si_clickjacking&m=on%09&t=6270"";}, 5000); window.document.write(""<style>body * { display:none !important; }<\/style><a href=\""#\"" onclick=\""top.location.href=window.location.href\"" style=\""display: block !important; padding: 10px\""><i class=\""img spritemap_aanaup sx_58594b\"" style=\""display:block !important\""><\/i>Go to Facebook.com<\/a>"");/* _b537lW0 */ }}/* ]]> */</script><script type=""text/javascript""> 
Env={user:0,locale:""en_US"",method:""GET"",dev:0,start:(new Date()).getTime(),ps_limit:5,ps_ratio:4,svn_rev:320840,static_base:""https:\/\/s-static.ak.facebook.com\/"",www_base:""http:\/\/www.facebook.com\/"",tlds:[""com""],rep_lag:20,pc:{""m"":""1.0.4"",""l"":""1.0.4"",""axi"":true,""j"":true,""bsz"":16},fb_dtsg:""E0iCD"",lhsh:""75601"",silent_oops_errors:""1"",ajax_threshold:""1"",use_css_import_in_ie:""1"",ajaxpipe_enabled:""1"",chat_fe_rewrite:""1"",ffid1:""tsrwXth9XWQR0OePzmlS-Q"",ffid2:""BnMS-7QmGkKZE-298hOsLw"",ffid3:""OWVmblRKMWo1OVpNY0drY2JjNGFtdGJi"",ffid4:""JMB2-k-IskDS96mpXxuO4A"",ffver:58931};
</script>
<script type=""text/javascript"">Bootloader.setResourceMap({omvrb: {type: 'css',name: 'css/4p738t2ew90k888g.pkg.css',permanent: 1,src: 'https://s-static.ak.facebook.com/rsrc.php/zo/r/m3Tla9bbrIo.css'},'r/gWs': {type: 'css',name: 'css/3xjd0tbhjmg4cgw0.pkg.css',src: 'https://s-static.ak.facebook.com/rsrc.php/zx/r/ac7q0b7pX55.css'},'+PLK+': {type: 'css',name: 'css/69lln7lv1wws008o.pkg.css',src: 'https://s-static.ak.facebook.com/rsrc.php/zZ/r/C4rLJTlB3Nb.css'},dLc2v: {type: 'css',name: 'css/2tqxhsviuqyo0go8.pkg.css',src: 'https://s-static.ak.facebook.com/rsrc.php/z2/r/yyvIue42m_y.css'},'hNs+8': {type: 'css',name: 'css/sprite/autogen/aanaup.css',permanent: 1,nonblocking: 1,src: 'https://s-static.ak.facebook.com/rsrc.php/zZ/r/1x2cFH1serd.css'},c54L1: {type: 'css',name: 'css/3i9jbos097okg88k.pkg.css',src: 'https://s-static.ak.facebook.com/rsrc.php/zI/r/zYyn_gPp6RA.css'},SPe3z: {type: 'css',name: 'css/ui/xhp/toggle.css',permanent: 1,src: 'https://s-static.ak.facebook.com/rsrc.php/zR/r/KZQaTjHR8wp.css'}});Bootloader.setResourceMap({S78Sf: {type: 'js',name: 'js/bgsb9agc7cgsgwc8.pkg.js',src: 'https://s-static.ak.facebook.com/rsrc.php/zT/r/r-WcbXXN1T7.js'},JtQur: {type: 'js',name: 'js/1o08uzit38is48gc.pkg.js',src: 'https://s-static.ak.facebook.com/rsrc.php/zl/r/0ioD8bCks7G.js'},dZmKL: {type: 'js',name: 'js/cv4867olo3cwsk8w.pkg.js',src: 'https://s-static.ak.facebook.com/rsrc.php/z7/r/u9PIFvXGGNt.js'},j6KLh: {type: 'js',name: 'js/8opmx1aaueckwc80.pkg.js',src: 'https://s-static.ak.facebook.com/rsrc.php/zQ/r/IUPuxNuZZDM.js'},'92bDI': {type: 'js',name: 'js/2lkjvir1y0ysw80s.pkg.js',src: 'https://s-static.ak.facebook.com/rsrc.php/z_/r/TMs3GjuM-TL.js'},z2MT6: {type: 'js',name: 'js/j17gq7zju74gwscc.pkg.js',src: 'https://s-static.ak.facebook.com/rsrc.php/z9/r/D9otk9q_4xp.js'},mgZyP: {type: 'js',name: 'js/296v2h7yh5a8ko88.pkg.js',src: 'https://s-static.ak.facebook.com/rsrc.php/zn/r/mLKLFeIkWvK.js'},b34IU: {type: 'js',name: 'js/ui/xhp/Toggler.js',src: 'https://s-static.ak.facebook.com/rsrc.php/zN/r/PbD_CkDvn44.js'}});
Bootloader.enableBootload({async: ['j6KLh','S78Sf','omvrb'],dialog: ['j6KLh','S78Sf','omvrb'],'dom-form': ['j6KLh','S78Sf','omvrb'],PhotoTheater: ['j6KLh','S78Sf','c54L1','92bDI','omvrb'],PhotoTagger: ['j6KLh','S78Sf','omvrb','z2MT6'],TagToken: ['j6KLh','S78Sf','mgZyP','z2MT6'],TagTokenizer: ['j6KLh','S78Sf','mgZyP','z2MT6','c54L1','92bDI','omvrb'],Toggler: ['j6KLh','S78Sf','SPe3z','b34IU'],'async-signal': ['S78Sf'],vector: ['S78Sf','j6KLh'],cookie: ['S78Sf'],'event-extensions': ['S78Sf','j6KLh'],'detect-broken-proxy-cache': ['S78Sf','j6KLh']});Arbiter.registerCallback(InitialJSLoader.callback, [""BOOTLOAD\/ROADRUNNER_READY""]);Arbiter.registerCallback(function(){setTimeout(function() {InitialJSLoader.load([""S78Sf"",""JtQur"",""dZmKL""]);Arbiter.inform(""BOOTLOAD\/ROADRUNNER_READY"", true, Arbiter.BEHAVIOR_STATE);}, 50)}, [OnloadEvent.ONLOAD_DOMCONTENT_CALLBACK]);</script><script type=""text/javascript""> 
Bootloader.configurePage([""omvrb"",""r\/gWs"",""+PLK+"",""dLc2v"",""hNs+8""]);
Bootloader.done([""js\/lib\/ua\/dimension.js"",""js\/login.js""]);
 
 
onloadRegister(function (){PopupResizer.init( { allowShrink : false } )});
onloadRegister(function (){window.loading_page_chrome = true;});
onloadRegister(function (){window.loading_page_chrome = false;});
onloadRegister(function (){useragent();});
onafterloadRegister(function (){Bootloader.loadComponents([""vector"",""cookie"",""event-extensions""], function(){ !function(){var a=function(){var b=0;return function(){if(!b){b=1;setTimeout(function(){b=0;var c=Vector2.getViewportDimensions();setCookie('wd',c.x+'x'+c.y);},100);}};}();onloadRegister(a);onloadRegister(function(){Event.listen(window,'resize',a);});onloadRegister(function(){Event.listen(window,'focus',a);});}(); });});
onafterloadRegister(function (){Bootloader.loadComponents([""detect-broken-proxy-cache""], function(){ detect_broken_proxy_cache(""0"", ""c_user"") });});
 
</script><script type=""text/javascript"">if(!window.ge)window.ge=function(a){return document.getElementById(a);};window.onload=function(a){return function(){var b=ge('email'),c=ge('pass');try{if(b&&!b.value){b.focus();}else if(c)c.focus();}catch(d){if(!(d.number==-2146826178))throw d;}return a&&a.call(window);};}(window.onload);function formchange(){(ge('persistent')||{}).checked=0;}function pop(a){window.open(a);}</script></body> 
</html> ";

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
        public void ShouldSubmitWebFormWithButton() {
            var url = "http://mysite.com/webform2.aspx";
            var expected = "success";
            Factory.Register(url, expected);
            var fields = new Dictionary<string, string>();
            var buttons = new Dictionary<string, string>();
            buttons.Add("login", "Entrar");
            var form = new WebForm { Action = url, Method = "POST", Fields = fields, Buttons = buttons, Cookies = new CookieCollection() };

            var response = form.Submit("login");

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
            var url = "https://graph.facebook.com/oauth/authorize?redirect_uri=http%3a%2f%2fwww.facebook.com%2fconnect%2flogin_success.html&type=user_agent&client_id=1234567890&display=popup";
            var action = "https://login.facebook.com/login.php?login_attempt=1&popup=1&fbconnect=1&display=popup&next=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Fuiserver.php%3Fmethod%3Dpermissions.request%26app_id%3D1234567890%26display%3Dpopup%26redirect_uri%3Dhttp%253A%252F%252Fwww.facebook.com%252Fconnect%252Flogin_success.html%26type%3Duser_agent%26fbconnect%3D1%26%252Aapp_id%252A%3D1234567890%26from_login%3D1&legacy_return=1";
            var expected = "<form action=\"" + action + "\" method=\"post\"><input name=email><input name=pass><input type=submit name=login></form>";
            Factory.Register(url, expected);
            Factory.Register(action, "success");

            var form = WebForm.Get(url);

            Assert.IsNotNull(form);
            Assert.AreEqual(action, form.Action);
            Assert.AreEqual("POST", form.Method);

            form.Fields["email"] = "facebookuser";
            form.Fields["pass"] = "s";

            Assert.AreEqual("success", form.Submit("login"));
        }

        [Test]
        public void ShouldDecodeFieldValue() {
            var form = WebForm.Build("<form><input name=\"encoded\" value=\"&lt;html&gt;\"></form>");

            Assert.IsNotNull(form);
            Assert.AreEqual(1, form.Fields.Count);
            Assert.AreEqual("<html>", form.Fields["encoded"]);
        }

        [Test]
        public void ShouldNotPutInputButtonAsField() {
            var form = WebForm.Build("<form><input name=\"field1\" value=\"1\" type=\"hidden\" /><input type=\"submit\" name=\"go\" value=\"GO\"  /></form>");
            Assert.IsNotNull(form);
            Assert.AreEqual(1, form.Fields.Count);
            Assert.AreEqual("1", form.Fields["field1"]);
            Assert.AreEqual("https://login.facebook.com/login.php?login_attempt=1&popup=1&fbconnect=1&display=popup&next=http%3A%2F%2Fwww.facebook.com%2Fconnect%2Fuiserver.php%3Fmethod%3Dpermissions.request%26app_id%3D161520467221210%26display%3Dpopup%26redirect_uri%3Dhttp%253A%252F%252Fwww.facebook.com%252Fconnect%252Flogin_success.html%26type%3Duser_agent%26fbconnect%3D1%26%252Aapp_id%252A%3D161520467221210%26from_login%3D1&legacy_return=1", form.Action);
            Assert.AreEqual("POST", form.Method);
        }

        [Test]
        public void ShouldConstructFacebookLoginForm() {
            Assert.True(true);
        }

        [Test]
        public void ShouldIgnoreInputFieldsWithoutName() {
            var form = WebForm.Build("<form><input name=\"field1\" value=\"1\" type=\"hidden\" /><input value=\"GO\"  /></form>");
            Assert.IsNotNull(form);
            Assert.AreEqual(1, form.Fields.Count);
            Assert.AreEqual("1", form.Fields["field1"]);
        }

        // textarea

        // select

        // checkbox

        // radiobutton

        [Test]
        public void ShouldFillAllFormPropertiesCorrectly() {
            var form = WebForm.Build("<form name=\"name1\" id=\"id2\" action=\"action3\" method=\"method4\" enctype=\"enctype5\"><input name=\"field1\" value=\"1\" /></form>");

            Assert.AreEqual("name1", form.Name);
            Assert.AreEqual("id2", form.Id);
            Assert.AreEqual("action3", form.Action);
            Assert.AreEqual("METHOD4", form.Method);
            Assert.AreEqual("method4", form.Method);
            Assert.AreEqual("enctype5", form.EncType);
        }

        // TODO: test post to relative url...

        private void AssertGoogleForm(WebForm form, bool absolute) {
            Assert.IsNotNull(form);
            if(absolute) {
                Assert.AreEqual("http://www.google.com/search", form.Action);
            } else {
                Assert.AreEqual("/search", form.Action);
            }
            Assert.AreEqual("GET", form.Method);
            Assert.AreEqual(5, form.Fields.Count);
            Assert.AreEqual(2, form.Buttons.Count);
            Assert.AreEqual("pt-BR", form.Fields["hl"]);
            Assert.IsNullOrEmpty(form.Id);
            Assert.IsNull(form.Id);
            Assert.AreEqual("f", form.Name);
            Assert.IsNullOrEmpty(form.EncType);
        }
    }
}
