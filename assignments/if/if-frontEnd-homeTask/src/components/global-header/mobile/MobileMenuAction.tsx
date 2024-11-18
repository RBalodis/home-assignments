import React, { HTMLAttributes, ReactNode } from 'react';
import { NavLink } from 'react-router-dom';
import classnames from 'classnames';

export interface MobileMenuActionBaseProps {
    children: ReactNode;
    className?: HTMLAttributes<HTMLElement>['className'];
    onClick?: HTMLAttributes<HTMLElement>['onClick'];
}

export type MobileMenuActionButtonProps = MobileMenuActionBaseProps;

export type MobileMenuActionLinkProps = {
    to: string;
} & MobileMenuActionBaseProps;

export enum MobileMenuActionAs {
    A = 'a',
    NAV_LINK = 'NavLink',
    BUTTON = 'button',
}

export type MobileMenuActionProps = {
    as: MobileMenuActionAs;
} & (MobileMenuActionButtonProps | MobileMenuActionLinkProps);

const MobileMenuActionButton = ({
    children,
    className,
    onClick,
}: MobileMenuActionButtonProps) => {
    return (
        <button
            onClick={onClick}
            className={classnames('if mobile-menu-action', className)}
        >
            {children}
        </button>
    );
};

const MobileMenuActionLink = ({
    children,
    className,
    onClick,
    to,
}: MobileMenuActionLinkProps) => {
    return (
        <NavLink
            onClick={onClick}
            to={to}
            className={classnames('if mobile-menu-action', className)}
        >
            {children}
        </NavLink>
    );
};

const MobileMenuActionExternalLink = ({
    children,
    className,
    onClick,
    to,
}: MobileMenuActionLinkProps) => {
    return (
        <a
            onClick={onClick}
            href={to}
            target="_blank"
            rel={'noreferrer'}
            className={classnames('if mobile-menu-action', className)}
        >
            {children}
        </a>
    );
};

export const MobileMenuAction = ({ as, ...props }: MobileMenuActionProps) => {
    switch (as) {
        case MobileMenuActionAs.BUTTON:
            return (
                <MobileMenuActionButton
                    onClick={props.onClick}
                    className={props.className}
                >
                    {props.children}
                </MobileMenuActionButton>
            );

        case MobileMenuActionAs.NAV_LINK:
            return (
                <MobileMenuActionLink
                    onClick={props.onClick}
                    to={(props as MobileMenuActionLinkProps).to}
                    className={props.className}
                >
                    {props.children}
                </MobileMenuActionLink>
            );

        case MobileMenuActionAs.A:
            return (
                <MobileMenuActionExternalLink
                    onClick={props.onClick}
                    to={(props as MobileMenuActionLinkProps).to}
                    className={props.className}
                >
                    {props.children}
                </MobileMenuActionExternalLink>
            );
    }
};
