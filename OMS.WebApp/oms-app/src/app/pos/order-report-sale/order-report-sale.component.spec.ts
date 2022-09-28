import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OrderReportSaleComponent } from './order-report-sale.component';

describe('OrderReportSaleComponent', () => {
  let component: OrderReportSaleComponent;
  let fixture: ComponentFixture<OrderReportSaleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OrderReportSaleComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OrderReportSaleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
