import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GetBaseUrl } from './providers/base.url';
import { HttpClientModule/*, HTTP_INTERCEPTORS */} from '@angular/common/http';
@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
  ],
  providers: [
  { provide: 'BASE_URL', useFactory: GetBaseUrl },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
