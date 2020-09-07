import { Component, OnInit } from '@angular/core';
import { classValunteer } from '../volunteer/models/classValunteer';
import { VolunteerService } from '../volunteer.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-volunteer-details',
  templateUrl: './volunteer-details.component.html',
  styleUrls: ['./volunteer-details.component.css']
})
export class VolunteerDetailsComponent implements OnInit {

 
  save(){
    
  }

  constructor(private _acr:ActivatedRoute,private _volunteerService: VolunteerService,private _router: Router) {
   
   }

  ngOnInit() {
     valunteer:classValunteer;
this._acr.paramMap.subscribe(params=>{
  let id= +params.get("id");
  this._volunteerService.getVolunteers().subscribe(data=>{
    if(id!=0){
      this.valunteer=data.filter(x=>x.id==id);
    }
  },err=>{
    this._router.navigate(["noooo"]);
  })
})
  }

}
