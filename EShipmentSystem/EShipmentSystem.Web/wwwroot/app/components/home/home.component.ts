import { Component, OnInit } from '@angular/core';

import { DataService } from '../../core/services/data.service';
import { AuthService } from '../../core/services/auth.service';
import { UtilityService } from '../../core/services/utility.service';

declare var $: any;
declare var moment: any;

@Component({
    selector: 'home',
    templateUrl: './app/components/home/home.component.html'
})
export class HomeComponent implements OnInit {

    constructor( private dataService: DataService,
        private authService: AuthService,
        private utilityService: UtilityService) {
    }

    ngOnInit() { }
}