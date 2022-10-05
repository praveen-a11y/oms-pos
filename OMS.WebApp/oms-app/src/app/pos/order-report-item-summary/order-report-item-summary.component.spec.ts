import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OrderReportItemSummaryComponent } from './order-report-item-summary.component';

describe('OrderReportItemSummaryComponent', () => {
  let component: OrderReportItemSummaryComponent;
  let fixture: ComponentFixture<OrderReportItemSummaryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OrderReportItemSummaryComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OrderReportItemSummaryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
