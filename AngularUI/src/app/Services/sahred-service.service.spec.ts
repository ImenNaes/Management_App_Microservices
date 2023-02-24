import { TestBed } from '@angular/core/testing';

import { SahredServiceService } from './sahred-service.service';

describe('SahredServiceService', () => {
  let service: SahredServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SahredServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
