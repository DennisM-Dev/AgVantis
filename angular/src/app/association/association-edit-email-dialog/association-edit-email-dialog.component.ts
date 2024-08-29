import {
  Component,
  OnInit,
  EventEmitter,
  Output,
  Injector
} from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { forEach as _forEach, includes as _includes, map as _map } from 'lodash-es';
import { AppComponentBase } from '@shared/app-component-base';
import { UserServiceProxy, AssociationServiceProxy, UserDto, ChangeAssociationEmailDto } from '@shared/service-proxies/service-proxies';

@Component({
  templateUrl: './association-edit-email-dialog.component.html'
})
export class AssociationEditEmailDialogComponent extends AppComponentBase
  implements OnInit {
      saving = false;
      id: number;
      user = new UserDto();
      newUser = new UserDto();

      @Output() onSave = new EventEmitter<any>();
    
      constructor(
        injector: Injector,
        public bsModalRef: BsModalRef,
        public _userService: UserServiceProxy,
        public _association: AssociationServiceProxy
      ) {
        super(injector);
      }

      ngOnInit(): void {}

      save(): void {
          this.saving = true;  
          let changeAssociationEmailDto = new ChangeAssociationEmailDto();
          changeAssociationEmailDto.currentEmailAddress = this.user.emailAddress;
          changeAssociationEmailDto.newEmailAddress = this.newUser.emailAddress;
          
          this._association.changeEmail(changeAssociationEmailDto).subscribe(() => {
            this.notify.info(this.l('SavedSuccessfully'));
            this.bsModalRef.hide();
            this.onSave.emit();
          }, 
        () => {
          this.saving = false;
        });
          this.saving = false;
      }
  }