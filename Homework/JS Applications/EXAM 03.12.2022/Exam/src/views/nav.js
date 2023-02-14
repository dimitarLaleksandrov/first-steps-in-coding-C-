import { html, render, page } from '../lib.js'
import { getUserData } from '../util.js';
import { logout } from '../api/user.js';
const nav = document.querySelector('header');

const navTemplate = (hasUser) => html `
 <a id="logo" href="/"><img id="logo-img" src="./images/logo.png" alt="" /></a>
<nav>
  <div>
    <a href="/catalog">Dashboard</a>
  </div>
  ${hasUser ? html`<a href="/create">Add Album</a>
  <a @click=${onLogout} href="javascript:void(0)">Logout</a>` : html`<a href="/login">Login</a>
  <a href="/register">Register</a>`
};
</nav>`;

export function updateNav(){
    const user = getUserData();
    render(navTemplate(user), nav);
}

export function onLogout(){
    logout();
    updateNav();
    page.redirect('/');
}