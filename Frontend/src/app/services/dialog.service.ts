import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ConfirmComponent } from '../dialogs/confirm/confirm.component';

@Injectable({
  providedIn: 'root',
})
export class DialogService {
  constructor(private dialog: MatDialog) {}

  confirmDialog() {
    this.dialog.open(ConfirmComponent);
  }
}
