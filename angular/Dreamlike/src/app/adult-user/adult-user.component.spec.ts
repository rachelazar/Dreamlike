import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdultUserComponent } from './adult-user.component';

describe('AdultUserComponent', () => {
  let component: AdultUserComponent;
  let fixture: ComponentFixture<AdultUserComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdultUserComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdultUserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
