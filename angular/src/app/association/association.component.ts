import { Component, Injector, ChangeDetectionStrategy, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { AssociationEditEmailDialogComponent } from './association-edit-email-dialog/association-edit-email-dialog.component';
import {
  UserDto,
  UserServiceProxy,
} from '@shared/service-proxies/service-proxies';

@Component({
  templateUrl: './association.component.html',
  styleUrl: './association.component.css',
  animations: [appModuleAnimation()],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class AssociationComponent extends AppComponentBase implements OnInit {
  saving = false;

  constructor(injector: Injector,
    private _modalService: BsModalService,
    public _userService: UserServiceProxy
  ) 
  {
    super(injector);
  }

  ngOnInit(): void {}
  
  editUserEmail(): void {
    this.showCreateOrEditEmailDialog(-1);
  }
  private showCreateOrEditEmailDialog(id?: number): void {  
    let EditAssociationEmailDialog: BsModalRef;
    EditAssociationEmailDialog = this._modalService.show(
      AssociationEditEmailDialogComponent,
      {
        class: 'modal-lg',
      }
    ); 
  }
}