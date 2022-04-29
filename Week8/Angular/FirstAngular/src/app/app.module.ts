import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { PixelCanvasComponent } from './pixel-canvas/pixel-canvas.component';

@NgModule({
  declarations: [
    AppComponent,
    PixelCanvasComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
