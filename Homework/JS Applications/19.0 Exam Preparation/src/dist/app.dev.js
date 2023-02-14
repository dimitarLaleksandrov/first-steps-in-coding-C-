"use strict";

var _user = require("./api/user.js");

var _lib = require("./lib.js");

var _util = require("./util.js");

var _catalog = require("./views/catalog.js");

var _home = require("./views/home.js");

var _login = require("./views/login.js");

var _nav = require("./views/nav.js");

var _register = require("./views/register.js");

var main = document.getElementById('content');
document.getElementById('logoutbtn').addEventListener('click', onLogout);
(0, _lib.page)(decorateContext);
(0, _lib.page)('/', _home.showHome);
(0, _lib.page)('/catalog', _catalog.showCatalog);
(0, _lib.page)('/catalog/:id', showDetails);
(0, _lib.page)('/edit/:id', function () {
  return console.log('edit/:id');
});
(0, _lib.page)('/create', function () {
  return console.log('create');
});
(0, _lib.page)('/login', _login.showLogin);
(0, _lib.page)('/register', _register.showRegister);
(0, _nav.updateNav)();

_lib.page.start();

function decorateContext(ctx, next) {
  ctx.render = renderMain;
  ctx, _nav.updateNav = (_nav.updateNav, function () {
    throw new Error('"' + "updateNav" + '" is read-only.');
  }());
  var user = (0, _util.getUserData)();

  if (user) {
    ctx.user = user;
  }

  next();
}

function renderMain(content) {
  (0, _lib.render)(content, main);
}