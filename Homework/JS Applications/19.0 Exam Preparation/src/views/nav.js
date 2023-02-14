import { html, render, page } from '../lib.js'
import { getUserData } from '../util.js';
import { logout } from '../api/user.js';
const nav = document.querySelector('header');

const navTemplate = (hasUser) => html `
<nav>
    <section class="logo">
        <img src="./images/logo.png" alt="logo">
         </section>
            <ul>
                <!--Users and Guest it will be market whit #-->
                <li><a href="/">Home</a></li>
                <li><a href="/catalog">Dashboard</a></li>
                ${!hasUser ? html`<li> class="guest"
                <a href="/register">Register</a></li>` : html`<li class="user"><a href="/create">Create Postcard</a></li>
                <li class="user"><a @click=${onLogout} id="logoutBtn" href="javascript:void(0)">Logout</a></li>`}         
            </ul>
</nav>`;

export function updateNav(){
    const user = getUserData();
    render(navTemplate(user), nav)
}
function onLogout(){
    logout();
    updateNav();
    page.redirect('/');
}