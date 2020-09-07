import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from "@angular/forms"
import{VolunteerComponent} from './volunteer/volunteer/volunteer.component'
import{SchedulingComponent} from './scheduling/scheduling/scheduling.component'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { HomeComponent } from './home/home.component';
import { NotFoundPageComponent } from './not-found-page/not-found-page.component';
import { VolunteerDetailsComponentComponent } from './volunteer-details-component/volunteer-details-component.component';
import { VolunteerDetailsComponent } from './volunteer/volunteer-details/volunteer-details.component';


@NgModule({
  declarations: [
    AppComponent, HomeComponent, NotFoundPageComponent, VolunteerComponent, SchedulingComponent, VolunteerDetailsComponentComponent, VolunteerDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
