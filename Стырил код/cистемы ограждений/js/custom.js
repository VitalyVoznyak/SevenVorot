$((function(){$(".main-menu__item.main-menu__item--lvl1 .main-menu__arrow").click((function(){$(this).parent().find(".main-menu__items-bg > .main-menu__items--lvl2").slideToggle(400)})),$(".main-menu__link.main-menu__link--lvl1").off("click"),$(".hits-tabs__tab").click((function(t){t.preventDefault();var i=$(this).index();$(".hits-tabs__tab").removeClass("is-current").eq(i).addClass("is-current"),$(".hits-tabs__content").removeClass("is-current").eq(i).addClass("is-current")})),$("#design-tool").on("click",(function(){const t=$(this).attr("href");return $.colorbox({href:t,iframe:!0,width:"90%",height:"80%"}),!1})),$("#check-list").on("click",(function(){const t=$(this).data("text");return $.colorbox({html:`<div class="calculator-popup"><div class="calculator-popup__text">${t}</div></div>`,width:"80%"}),!1}))}));