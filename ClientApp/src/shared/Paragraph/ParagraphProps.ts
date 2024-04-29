enum AvaiableStyles {
    Paragraph1 = 'paragraph1'
}

export interface ParagraphProps {
    fontSize?: string
    color?: string
    styleType?: AvaiableStyles
    frozen?: boolean
    children: React.ReactNode
}
