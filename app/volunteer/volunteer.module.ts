import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { VolunteerService } from './volunteer.service';



@NgModule({
  declarations: [],
  providers:[VolunteerService],
  imports: [
    CommonModule
  ]
})
export class VolunteerModule { }
