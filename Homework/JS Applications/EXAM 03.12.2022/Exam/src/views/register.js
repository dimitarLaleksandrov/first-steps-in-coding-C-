import { html } from '../lib.js';
import { updateNav } from './nav.js';
import { register } from '../api/user.js';
import { createSubmitHandler } from '../util.js';

const registerTemplate = (onRegister) => html ` 
<section id="register">
<div class="form">
  <h2>Register</h2>
  <form class="login-form">
    <input type="text" name="email" id="register-email" placeholder="email" />
    <input type="password" name="password" id="register-password" placeholder="password" />
    <input type="password" name="re-password" id="repeat-password" placeholder="repeat password" />
    <button type="submit">register</button>
    <p class="message">Already registered? <a href="#">Login</a></p>
  </form>
</div>
</section>`;

export function showRegister(ctx) {
    ctx.render(registerTemplate(createSubmitHandler(onRegister)));
    async function onRegister(email, password, repeatPassword) {
        if (email == '' || password == '') {
            return alert('All fields are required!');
        }
        if (password !== repeatPassword) {
            return alert('Password don\'t match!');
        }
        await register(email, password);
        ctx.updateNav();
        ctx.page.redirect('/');
    }
}