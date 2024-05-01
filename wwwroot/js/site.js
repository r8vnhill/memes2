async function loadPDF(pdfPath) {
    const pdf = await pdfjsLib.getDocument(pdfPath).promise;
    const page = await pdf.getPage(1); // Get the first page
    const scale = 1.5; // Render scale
    const viewport = page.getViewport({scale: scale});

    const canvas = document.getElementById('pdf-canvas');
    const context = canvas.getContext('2d');
    canvas.height = viewport.height;
    canvas.width = viewport.width;

    const renderContext = {
        canvasContext: context,
        viewport: viewport
    };
    await page.render(renderContext).promise;
}