import { ComponentFixture, TestBed } from '@angular/core/testing';
import { SweDemoAppDutil } from './swe-demo-app-dutil';

describe('SweDemoAppDutil', () => {
  let component: SweDemoAppDutil;
  let fixture: ComponentFixture<SweDemoAppDutil>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SweDemoAppDutil],
    }).compileComponents();

    fixture = TestBed.createComponent(SweDemoAppDutil);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
