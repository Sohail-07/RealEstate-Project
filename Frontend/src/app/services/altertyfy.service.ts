import { Injectable } from '@angular/core';
import * as altertyfy from 'alertifyjs';

@Injectable({
  providedIn: 'root',
})
export class AltertyfyService {
  constructor() {}

  success(message: string) {
    altertyfy.success(message);
  }
  warning(message: string) {
    altertyfy.warning(message);
  }
  error(message: string) {
    altertyfy.error(message);
  }
}
