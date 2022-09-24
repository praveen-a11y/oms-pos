import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PinValidateDialogComponent } from './pin-validate-dialog.component';

describe('PinValidateDialogComponent', () => {
  let component: PinValidateDialogComponent;
  let fixture: ComponentFixture<PinValidateDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PinValidateDialogComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PinValidateDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
