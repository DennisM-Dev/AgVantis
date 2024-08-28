import { AgVantisTemplatePage } from './app.po';

describe('AgVantis App', function() {
  let page: AgVantisTemplatePage;

  beforeEach(() => {
    page = new AgVantisTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
