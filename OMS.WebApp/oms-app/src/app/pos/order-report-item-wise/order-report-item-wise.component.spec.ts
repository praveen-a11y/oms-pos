import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OrderReportItemWiseComponent } from './order-report-item-wise.component';

describe('OrderReportItemWiseComponent', () => {
  let component: OrderReportItemWiseComponent;
  let fixture: ComponentFixture<OrderReportItemWiseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OrderReportItemWiseComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OrderReportItemWiseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
