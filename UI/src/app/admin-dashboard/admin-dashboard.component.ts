import { Component, OnInit } from '@angular/core';
import { Router } from "@angular/router";
import * as _ from "underscore";
import { AuthService } from "src/app/shared/services/auth.service";

@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.css']
})
export class AdminDashboardComponent implements OnInit {

  lid: number;
  role: number;
  userData: any;
  constructor(private router: Router, private auth: AuthService) {
    
   }

  ngOnInit() {
    
  }
  notification() {
    if (this.userData.role === 1) {
      alert("No Notification Yet");
    } else if (this.userData.role === 2) {
      this.router.navigateByUrl("/trainer-dashboard/trainer-notification");
    } else if (this.userData.role == 3) {
      this.router.navigateByUrl("/user-dashboard/user-notification");
    } else {
      console.log("Invalid User");
    }
  }
  
  logout() {
    localStorage.clear();
    this.router.navigate(["home"]);
    alert("Logged out successfully!");
  }

}
