function r(t){/in/.test(document.readyState)?setTimeout("r("+t+")",9):t()}$((function(){var t=$(".add2basket-popup"),e=$(".add2basket-popup__corner");window.addEventListener("message",(function(a){a.origin===window.location.origin&&(data=a.data,data.dealerCode&&($imgs=$(".dha-preview img"),img=$imgs[$imgs.length-1].currentSrc,data.img=img,startLoaderF(),$.ajax({url:"/.ajax/result/calc2basket.php",data:{eventData:JSON.stringify(data)},method:"post",success:function(a){let s=JSON.parse(a);if(!0===s.result){let a=$("#dhaide").find("#dha-book");setTimeout((function(){$(".header-basket").html($(s.smallBasket).html()),endLoaderF(),function(a,s){var i,o,d=$(".add2basket-popup__message"),n=(s=s||"Товар добавлен в корзину",a.offset().top),r=a.offset().left,u=a.outerWidth(),l=0,m=t.outerWidth(),c=t.outerHeight();d.html(s),i=n-c-11,(l=r+u/2-m/2)<15&&(l=15),l+m>document.documentElement.clientWidth+15&&(l=document.documentElement.clientWidth-m-15),o=r+u/2-8,t.offset({top:i,left:l}).addClass("is-show"),e.offset({left:o})}(a,s.message)}),800)}},error:function(){endLoaderF()}})))}))})),r((function(){if(document.getElementsByClassName)t=document.getElementsByClassName("youtube");else var t=function(t,e){for(var a=[],s=new RegExp("(^| )"+e+"( |$)"),i=t.getElementsByTagName("*"),o=0,d=i.length;o<d;o++)s.test(i[o].className)&&a.push(i[o]);return a}(document.body,"youtube");for(var e=t.length,a=0;a<e;a++){t[a].style.backgroundImage="url(http://i.ytimg.com/vi/"+t[a].id+"/sddefault.jpg)";var s=document.createElement("div");s.setAttribute("class","play"),t[a].appendChild(s),t[a].onclick=function(){var t=document.createElement("iframe"),e="https://www.youtube.com/embed/"+this.id+"?autoplay=1&autohide=1&rel=0";this.getAttribute("data-params")&&(e+="&"+this.getAttribute("data-params")),t.setAttribute("src",e),t.setAttribute("frameborder","0"),t.setAttribute("allowfullscreen",""),t.style.width=this.style.width,t.style.height=this.style.height,this.parentNode.replaceChild(t,this)}}}));