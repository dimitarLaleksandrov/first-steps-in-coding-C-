//import { page, render } from './lib.js';
import { getUserData } from './util.js';
import { showDashbord } from './views/dashbord.js';
import { showHome } from './views/homePage.js';
import { showLogin } from './views/login.js';
import { updateNav } from './views/nav.js';
import { showRegister } from './views/register.js';
import { onLogout } from '.views/nav.js';
import { showCreate } from './views/createAlbume.js';
import { showCatalog } from './views/catalogViews.js';
import { showEdit } from './views/editView.js';

const main = document.getElementById('home');
document.getElementById('logoutbtn').addEventListener('click', onLogout);

page(decorateContext);
page('/', showHome);
page('/catalog', showDashbord);
page('/details-wrapper/:id', showCatalog);
page('/edit/:id', showEdit);
page('/logout', onLogout);
page('/create', showCreate);
page('/login', showLogin);
page('/register', showRegister);
page('/delete', showRegister);



updateNav();
page.start();

function decorateContext(ctx, next) {
    ctx.render = renderMain;
    ctx, updateNav = updateNav;

    const user = getUserData();
    if (user) {
        ctx.user = user;
    }

    next();
}

function renderMain(content) {
    render(content, main);
}