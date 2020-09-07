import { Component, OnInit } from '@angular/core';
import{VolunteerService} from '../volunteer.service'
import { classValunteer } from './models/classValunteer';
import { Router } from '@angular/router';

@Component({
  selector: 'app-volunteer',
  templateUrl: './volunteer.component.html',
  styleUrls: ['./volunteer.component.css']
})
export class VolunteerComponent implements OnInit {

  volunteersList:classValunteer[]
  days:string[]

  viewVolunteer(item:classValunteer){
    this._router.navigate(["/editForm", item.]);
  }
  getVolunteer(){
    
      this._volunteerService.getVolunteers().subscribe(data => {
      this.volunteersList = data;
    },err =>{
      this.volunteersList = [];
      alert("err");
    });
  }
  constructor(private _volunteerService: VolunteerService,private _router: Router) {
    this.getVolunteer();
    this.days=["ראשון","שני","שלישי","רביעי","חמישי","שישי"]
  }

  ngOnInit() {
    
  }

}
