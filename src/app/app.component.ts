import { Component } from '@angular/core';

import { AuthService } from './user/auth.service';
import { Router } from '@angular/router';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html'
})
export class AppComponent {
    pageTitle = 'Acme Product Management';

    constructor(private router: Router, public authService: AuthService) { }

    logOut(): void {
        this.authService.logout();
        this.router.navigateByUrl('/welcome'); // byurl cleans up all secondary windows
    }
}
