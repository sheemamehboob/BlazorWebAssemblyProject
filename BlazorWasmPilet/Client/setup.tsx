import { PiletApi } from "../piral~/BlazorWasmPilet.Client/node_modules/goodhealth-piral";

export default (app: PiletApi) => {
    app.registerTile(app.fromBlazor("my-tile"));
    app.registerMenu(app.fromBlazor("Providers-Menu"));
    app.registerPage("/providers", app.fromBlazor("providers"));    
};
