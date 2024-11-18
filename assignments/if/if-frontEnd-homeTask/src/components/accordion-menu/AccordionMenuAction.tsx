import React, { HTMLAttributes, ReactNode } from 'react';
import { NavLink } from 'react-router-dom';
import classnames from 'classnames';

interface AccordionMenuActionBaseProps {
    children: ReactNode;
    className?: HTMLAttributes<HTMLElement>['className'];
    onClick?: HTMLAttributes<HTMLElement>['onClick'];
}

export type AccordionMenuActionButtonProps = AccordionMenuActionBaseProps;

export type AccordionMenuActionLinkProps = {
    to: string;
} & AccordionMenuActionBaseProps;

export enum AccordionMenuActionAs {
    A = 'a',
    NAV_LINK = 'NavLink',
    BUTTON = 'button',
}

export type AccordionMenuActionProps = {
    as: AccordionMenuActionAs;
} & (AccordionMenuActionButtonProps | AccordionMenuActionLinkProps);

const AccordionMenuActionButton = ({
    children,
    className,
    onClick,
}: AccordionMenuActionButtonProps) => {
    return (
        <button onClick={onClick} className={classnames('if', className)}>
            {children}
        </button>
    );
};

const AccordionMenuActionLink = ({
    children,
    className,
    onClick,
    to,
}: AccordionMenuActionLinkProps) => {
    return (
        <NavLink
            onClick={onClick}
            to={to}
            className={({ isActive }) =>
                classnames('if', className, isActive ? 'is-active' : '')
            }
        >
            {children}
        </NavLink>
    );
};

const AccordionMenuActionExternalLink = ({
    children,
    className,
    onClick,
    to,
}: AccordionMenuActionLinkProps) => {
    return (
        <a
            onClick={onClick}
            href={to}
            target="_blank"
            rel={'noreferrer'}
            className={classnames('if', className)}
        >
            {children}
        </a>
    );
};

export const AccordionMenuAction = ({
    as,
    ...props
}: AccordionMenuActionProps) => {
    switch (as) {
        case AccordionMenuActionAs.BUTTON:
            return (
                <AccordionMenuActionButton
                    onClick={props.onClick}
                    className={props.className}
                >
                    {props.children}
                </AccordionMenuActionButton>
            );

        case AccordionMenuActionAs.NAV_LINK:
            return (
                <AccordionMenuActionLink
                    onClick={props.onClick}
                    to={(props as AccordionMenuActionLinkProps).to}
                    className={props.className}
                >
                    {props.children}
                </AccordionMenuActionLink>
            );

        case AccordionMenuActionAs.A:
            return (
                <AccordionMenuActionExternalLink
                    onClick={props.onClick}
                    to={(props as AccordionMenuActionLinkProps).to}
                    className={props.className}
                >
                    {props.children}
                </AccordionMenuActionExternalLink>
            );
    }
};
