import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { SchedulingComponent} from './scheduling/scheduling/scheduling.component'
import { VolunteerComponent} from './volunteer/volunteer/volunteer.component'
import { NotFoundPageComponent } from './not-found-page/not-found-page.component';
import { VolunteerDetailsComponent } from './volunteer/volunteer-details/volunteer-details.component';


const routes: Routes = [
  { path: "", pathMatch: "full", redirectTo: "home" },
  { path: "home", component: HomeComponent },
  { path: "scheduling", component: SchedulingComponent },
  { path: "volunteer", component: VolunteerComponent },
  { path: "editForm/:id", component: VolunteerDetailsComponent },
  // { path: "setting", loadChildren: () => import("./setting/first-setting/first-setting.component").then(m => m.FirstSettingComponent) },
  { path: "**", component: NotFoundPageComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
