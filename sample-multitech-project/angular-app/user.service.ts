import { Injectable } from '@angular/core';
import { of } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class UserService {

  getUser(id: number) {
    return of({ id, name: 'Dummy User' });
  }
}
